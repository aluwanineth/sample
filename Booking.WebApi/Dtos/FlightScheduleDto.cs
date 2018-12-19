using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    /// <summary>
    /// FlightScheduleDto
    /// </summary>
    [DataContract]
    public class FlightScheduleDto
    {
        /// <summary>
        /// Flight Schedule Id
        /// </summary>
        [DataMember]
        [JsonProperty("flightScheduleId")]
        public int FlightScheduleId { get; set; }
        /// <summary>
        /// Flight Id
        /// </summary>
        [DataMember]
        [JsonProperty("flightId")]
        public int FlightId { get; set; }
        /// <summary>
        /// Airport Id
        /// </summary>
        [DataMember]
        [JsonProperty("airportId")]
        public int AirportId { get; set; }
        /// <summary>
        /// Depature Date Time
        /// </summary>
        [DataMember]
        [JsonProperty("depatureDateTime")]
        public DateTime DepatureDateTime { get; set; }
        /// <summary>
        /// From Destination
        /// </summary>
        [DataMember]
        [JsonProperty("fromDestination")]
        public string FromDestination { get; set; }
        /// <summary>
        /// To Destination
        /// </summary>
        [DataMember]
        [JsonProperty("toDestination")]
        public string ToDestination { get; set; }

    }
}
