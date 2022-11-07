using Newtonsoft.Json;
using ViOtpApi.Models;

namespace ViOtpApi.ViewModels
{
    public class RequestPhoneNumberResponseModel
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("re_phone_number")]
        public string RePhoneNumber { get; set; }

        [JsonProperty("CountryISO")]
        public CountryType CountryIso { get; set; }

        public string CountryCode { get; set; }

        public double Balance { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}