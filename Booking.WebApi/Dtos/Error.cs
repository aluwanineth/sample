using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    public class Error
    {
        [JsonProperty("errors")]
        public ErrorItem Errors { get; set; }
    }
}
