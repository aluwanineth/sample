using Booking.WebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.WebApi.Models
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext()
        {

        }

        public BookingDBContext(DbContextOptions<BookingDBContext> options)
           : base(options)
        {

        }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightSchedule> FlightSchedules { get; set; }
    }
}
