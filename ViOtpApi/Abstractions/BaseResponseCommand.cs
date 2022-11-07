using Newtonsoft.Json;
using ViOtpApi.Models;

namespace ViOtpApi.Abstractions
{
    public class BaseResponseCommand<TResponse>
    {
        [JsonProperty("status_code")]
        public StatusCodeType StatusCode { get; set; }

        public string Message { get; set; }

        public TResponse Data { get; set; }
    }
}