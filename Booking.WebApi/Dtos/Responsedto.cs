using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    /// <summary>
    /// ResponseDto
    /// </summary>
    [DataContract]
    public class ResponseDto
    {
        /// <summary>
        /// ItemResponses
        /// </summary>
        [DataMember]
        [JsonProperty("itemResponses")]
        public List<ItemResponseDto> ItemResponses { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [DataMember]
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [DataMember(Name = "Error")]
        [JsonProperty("errors")]
        public Error Error { get; set; }

    }
}
