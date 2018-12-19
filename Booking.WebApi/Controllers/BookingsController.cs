using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Booking.WebApi.Contracts;
using Booking.WebApi.Dtos;
using Booking.WebApi.Helpers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Booking.WebApi.Controllers
{
   
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingsController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), 200)]
        [Route("createBooking")]
        public async Task<IActionResult> CreateBooking(BookingDetailsDto bookingDetailsDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            int response = await _bookingRepository.CreateBookingAsync(bookingDetailsDto);

            if (response > -1)
            {
                return NotFound(new ApiResponse(404, "Booking page not found"));
            }
            return Ok(new ApiOkResponse(response));
        }
        [HttpPost("getAvailableflight")]
        [ProducesResponseType(typeof(ResponseDto), 200)]
        [ProducesResponseType(typeof(Error), 400)]

        public IActionResult GetAvailableflight([FromBody]SearchInputDto searchInputDto)
        {
            ResponseDto response = new ResponseDto();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                response = _bookingRepository.GetAvailableFlight(searchInputDto);

                if (response == null)
                {
                    return NotFound(new ApiResponse(404, "Booking page not found"));
                }

                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


    }
}
