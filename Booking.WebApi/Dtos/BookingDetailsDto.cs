using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    /// <summary>
    /// BookingDetailsDto
    /// </summary>
    [DataContract]
    public class BookingDetailsDto
    {
        /// <summary>
        /// booking Detail Id
        /// </summary>
        [DataMember]
        [JsonProperty("bookingDetailId")]
        public int BookingDetailId { get; set; }
        /// <summary>
        /// flight Schedule Id
        /// </summary>
        [DataMember]
        [JsonProperty("flightScheduleId")]
        public int FlightScheduleId { get; set; }
        /// <summary>
        /// no Of Passenger
        /// </summary>
        [DataMember]
        [JsonProperty("noOfPassenger")]
        public int NoOfPassenger { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [JsonProperty("remarks")]
        public string Remarks { get; set; }
        /// <summary>
        /// Booker Name
        /// </summary>
        [DataMember]
        [JsonProperty("booker Name")]
        public string BookerName { get; set; }
        
    }
}
