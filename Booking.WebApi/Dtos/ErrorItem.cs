using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking.WebApi.Dtos
{
    public class ErrorItem
    {
        [JsonProperty("methodName")]
        public string MethodName { get; set; }
        [JsonProperty("userMessage")]
        public string UserMessage { get; set; }
        [JsonProperty("internalMessage")]
        public string InternalMessage { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
