using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.WebApi.Models.Entities
{
    public class FlightSchedule
    {
        public int FlightScheduleId {get;set;}
        public int FlightId { get; set; }
        public int AirportId { get; set; }
        public DateTime DepatureDateTime { get; set; }
        public string FromDestination { get; set; }
        public string ToDestination { get; set; }
        public Flight Flight { get; set; }
        public Airport Airport { get; set; }
    }
}
