using System.Collections.Generic;
using Newtonsoft.Json;
using ViOtpApi.Models;

namespace ViOtpApi.Abstractions
{
    public class BaseListResponseModel<TResponse>
    {
        [JsonProperty("status_code")]
        public StatusCodeType StatusCode { get; set; }

        public string Message { get; set; }

        public IEnumerable<TResponse> Data { get; set; }
    }
}