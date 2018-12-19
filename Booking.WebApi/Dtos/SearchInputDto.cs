using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    /// <summary>
    /// SearchInputDto
    /// </summary>
    [DataContract]
    public class SearchInputDto
    {
        /// <summary>
        /// FromDesitination
        /// </summary>
        [DataMember]
        [JsonProperty("fromDestination")]
        public string FromDestination { get; set; }

        /// <summary>
        /// ToDesitination
        /// </summary>
        [DataMember]
        [JsonProperty("toDestination")]
        public string ToDestination { get; set; }

        /// <summary>
        /// depatureDateTime
        /// </summary>
        [DataMember]
        [JsonProperty("depatureDateTime")]
        public DateTime DepatureDateTime { get; set; }

        /// <summary>
        /// depatureDateTime
        /// </summary>
        [DataMember]
        [JsonProperty("returnDepatureDateTime")]
        public DateTime ReturnDepatureDateTime { get; set; }

        /// <summary>
        /// NoOfPassenger
        /// </summary>
        [DataMember]
        [JsonProperty("numberOfPassenger")]
        public int NoOfPassenger { get; set; }
    }
}
