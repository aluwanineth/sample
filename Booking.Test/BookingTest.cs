using Booking.WebApi.Contracts;
using Booking.WebApi.Controllers;
using Booking.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace Booking.Test
{
    public class BookingTest
    {
        BookingsController _controller;
        IBookingRepository _service;

        public BookingTest()
        {
            _service = new BookingServiceFake();
            _controller = new BookingsController(_service);
        }
        [Fact]
        public void Search_Flight_InvalidObjectPassed_ReturnsBadRequest()
        {
            SearchInputDto searchInput = new SearchInputDto()
            {
                DepatureDateTime = Convert.ToDateTime(""),
                FromDestination = "Johannesburg",
                ToDestination = "Durban",
                NoOfPassenger = 50
            };

            _controller.ModelState.AddModelError("DepatureDateTime", "Required");
            var badResponse = _controller.GetAvailableflight(searchInput);

            Assert.IsType<BadRequestObjectResult>(badResponse);

        }
        [Fact]
        public void Add_Valid_Search_Flight__ObjectPassed_ReturnsCreatedResponse()
        {

            SearchInputDto searchInput = new SearchInputDto()
            {
                DepatureDateTime = Convert.ToDateTime("2018-11-26"),
                FromDestination = "Johannesburg",
                ToDestination = "Durban",
                NoOfPassenger = 50
            };

            var createdResponse = _service.GetAvailableFlight(searchInput);
            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }

        [Fact]
        public void Add_InvalidBookingObjectPassed_ReturnsBadRequest()
        {
            var FlightScheduleIdMissingItem = new BookingDetailsDto()
            {
                BookerName = "Aluwani",
                NoOfPassenger = 20,
                Remarks = "Good service",
            };
            _controller.ModelState.AddModelError("FlightScheduleId", "Required");
            var badResponse = _controller.CreateBooking(FlightScheduleIdMissingItem);
            Assert.IsType<BadRequestObjectResult>(badResponse);
        }


        [Fact]
        public void Add_ValidBookingObjectPassed_ReturnsCreatedResponse()
        {
            var bookingTestData = new BookingDetailsDto()
            {
                BookerName = "Aluwani",
                NoOfPassenger = 20,
                Remarks = "Good service",
                FlightScheduleId = 1
            };
            var createdResponse = _controller.CreateBooking(bookingTestData);
            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }


        [Fact]
        public void Add_ValidBookingObjectPassed_ReturnedResponseHasCreatedItem()
        {
            var bookingTestData = new BookingDetailsDto()
            {
                BookerName = "Aluwani",
                NoOfPassenger = 20,
                Remarks = "Good service",
                FlightScheduleId = 1
            };
            var createdResponse = _controller.CreateBooking(bookingTestData);
            var item = createdResponse.Result as BookingDetailsDto;

            // Assert
            Assert.IsType<BookingDetailsDto>(item);
            Assert.Equal("Aluwani", item.BookerName);
        }


        [Fact]
        public void Add_Valid_Search_Flight_ObjectPassed_ReturnedResponseHasCreatedItem()
        {
            SearchInputDto searchInput = new SearchInputDto()
            {
                DepatureDateTime = Convert.ToDateTime("2018-11-26"),
                FromDestination = "Johannesburg",
                ToDestination = "Durban",
                NoOfPassenger = 50
            };
            var createdResponse = _service.GetAvailableFlight(searchInput);
            var item = createdResponse.ItemResponses as List<ItemResponseDto>;

            // Assert
            Assert.IsType<List<ItemResponseDto>>(item);
            Assert.Single(item);
        }
    }
}
