using System;
using Newtonsoft.Json;
using ViOtpApi.Models;

namespace ViOtpApi.ViewModels
{
    public class OtpResultResponseModel
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        public string Phone { get; set; }

        [JsonProperty("ServiceID")]
        public string ServiceId { get; set; }

        public string ServiceName { get; set; }

        public OtpStatusType Status { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedTime { get; set; }

        public bool IsSound { get; set; }

        public string SmsContent { get; set; }

        public string Code { get; set; }

        public string PhoneOriginal { get; set; }

        [JsonProperty("CountryISO")]
        public CountryType CountryIso { get; set; }

        public string CountryCode { get; set; }
    }
}