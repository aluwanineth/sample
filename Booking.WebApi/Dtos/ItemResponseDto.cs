using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    /// <summary>
    /// ItemResponseDto
    /// </summary>
    [DataContract]
    public class ItemResponseDto
    {
        /// <summary>
        /// FlightName
        /// </summary>
        [DataMember]
        public string FlightName { get; set; }
        /// <summary>
        /// AvailableSeat
        /// </summary>
        [DataMember]
        public int AvailableSeat { get; set; }
        /// <summary>
        /// FlightScheduleId
        /// </summary>
        [DataMember]
        public int FlightScheduleId { get; set; }
        /// <summary>
        /// BookingAvailable
        /// </summary>
        [DataMember]
        public bool BookingAvailable { get; set; }
        
    }
}
