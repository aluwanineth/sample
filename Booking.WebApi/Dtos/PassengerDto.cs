using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    // <summary>
    /// PassengerDto
    /// /summary>
    [DataContract]
    public class PassengerDto
    {
        /// <summary>
        /// Total Passengers
        /// </summary>
        [DataMember]
        [JsonProperty("totalPassengers")]
        public int TotalPassengers { get; set; }

        /// <summary>
        /// Flight ScheduleId
        /// </summary>
        [DataMember]
        [JsonProperty("flightScheduleId")]
        public int FlightScheduleId { get; set; }
    }
}
