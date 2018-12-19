using Booking.WebApi.Contracts;
using Booking.WebApi.Dtos;
using Booking.WebApi.Models;
using Booking.WebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.Services
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingDBContext _bookingDBContext;

        public BookingRepository(BookingDBContext bookingDBContext)
        {
            _bookingDBContext = bookingDBContext;
        }
        private List<PassengerDto> GetTotalPassengers()
        {
            List<PassengerDto> passengerDtos = new List<PassengerDto>();
            var query = from b in _bookingDBContext.BookingDetails
                        group b by new
                        {
                            b.FlightScheduleId
                        } into g
                        select new
                        {
                            TotalNumberOfPassenger = g.Sum(p => p.NoOfPassenger),
                            g.Key.FlightScheduleId
                        };
            foreach(var q in query)
            {
                PassengerDto passenger = new PassengerDto
                {
                    FlightScheduleId = q.FlightScheduleId,
                    TotalPassengers = q.TotalNumberOfPassenger
                };
                passengerDtos.Add(passenger);
            }
            return passengerDtos;
        }
       

        public async Task<int> CreateBookingAsync(BookingDetailsDto booking)
        {
            await _bookingDBContext.AddAsync(booking);
            await _bookingDBContext.SaveChangesAsync();
            return booking.BookingDetailId;
        }

        public ResponseDto GetAvailableFlight(SearchInputDto searchInput)
        {
            ResponseDto response = new ResponseDto();
            List<ItemResponseDto> responseItem = new List<ItemResponseDto>();
            try
            {
                
                foreach (var passenger in GetTotalPassengers())
                {
                    var query = from fs in _bookingDBContext.FlightSchedules
                                where
                                  fs.FromDestination == searchInput.FromDestination &&
                                  fs.ToDestination == searchInput.ToDestination &&
                                  fs.DepatureDateTime == searchInput.DepatureDateTime &&
                                  passenger.TotalPassengers < fs.Flight.Capacity
                                group new { fs.Flight, fs } by new
                                {
                                    fs.Flight.FlightId,
                                    fs.Flight.Name,
                                    fs.FlightScheduleId,
                                    fs.Flight.Capacity
                                } into g
                                select new
                                {
                                    g.Key.FlightId,
                                    g.Key.Name,
                                    g.Key.FlightScheduleId,
                                    TotalSeatLeft = (g.Key.Capacity - passenger.TotalPassengers)
                                };
                    foreach (var q in query)
                    {
                        bool bookingCheck = false;
                        if (searchInput.NoOfPassenger > q.TotalSeatLeft)
                            bookingCheck = false;
                        else
                            bookingCheck = true;
                        ItemResponseDto responseDto = new ItemResponseDto
                        {
                            AvailableSeat = q.TotalSeatLeft,
                            FlightName = q.Name,
                            BookingAvailable = bookingCheck,
                            FlightScheduleId = q.FlightScheduleId
                        };

                        responseItem.Add(responseDto);
                                              
                        
                    }

                }
                response.ItemResponses = responseItem;
            }
            catch(Exception ex)
            {
                ErrorItem errorItem = new ErrorItem
                {
                    Code = 400,
                    InternalMessage = ex.Message,
                    UserMessage = "Error occurs while searching for available flights",
                    MethodName = "GetAvailableFlight"
                };
                Error error = new Error
                {
                    Errors = errorItem
                };
                response.Error = error;
            }
            return response;
        }    
    }

}
