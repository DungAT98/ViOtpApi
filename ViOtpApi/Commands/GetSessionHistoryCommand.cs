using System;
using Newtonsoft.Json;
using ViOtpApi.Abstractions;
using ViOtpApi.JsonConverter;
using ViOtpApi.Models;

namespace ViOtpApi.Commands
{
    public class GetSessionHistoryCommand : BaseRequestCommand
    {
        public string Service { get; set; }

        public OtpStatusType Status { get; set; }

        public int Limit { get; set; }

        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? FromDate { get; set; }
        
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? ToDate { get; set; }
    }
}