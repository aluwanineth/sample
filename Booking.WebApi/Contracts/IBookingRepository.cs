using Booking.WebApi.Dtos;
using Booking.WebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Booking.WebApi.Contracts
{
    public interface IBookingRepository
    {
        ResponseDto GetAvailableFlight(SearchInputDto searchInput);
        Task<int> CreateBookingAsync(BookingDetailsDto booking);
    }
}
