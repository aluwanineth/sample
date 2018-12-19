using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.WebApi.Models.Entities
{
    public class BookingDetail
    {
        public int BookingDetailId { get; set; }
        public int FlightScheduleId { get; set; }
        public int NoOfPassenger { get; set; }
        public string Remarks { get; set; }
        public string BookerName { get; set; }
        public FlightSchedule FlightSchedule { get; set; }
    }
}
