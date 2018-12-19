using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.WebApi.Models.Entities
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }

    }
}
