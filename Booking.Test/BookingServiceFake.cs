using Booking.WebApi.Contracts;
using Booking.WebApi.Dtos;
using Booking.WebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Test
{
    public class BookingServiceFake : IBookingRepository
    {
        public Task<int> CreateBookingAsync(BookingDetailsDto booking)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetAvailableFlight(SearchInputDto searchInput)
        {
            List<ItemResponseDto> itemResponses = new List<ItemResponseDto>();
            ItemResponseDto itemResponseDto = new ItemResponseDto()
            {
                AvailableSeat = 20,
                BookingAvailable = true,
                FlightName = "SAA Mango",
                FlightScheduleId = 1
            };
            itemResponses.Add(itemResponseDto);
            ResponseDto responseDto = new ResponseDto
            {
                ItemResponses = itemResponses,
                Status = 200,
                Error = null
            };
            return responseDto;
        }


    }
}
