using System;
using Newtonsoft.Json;
using RestSharp;
using ViOtpApi.Abstractions;
using ViOtpApi.JsonConverter;
using ViOtpApi.Models;

namespace ViOtpApi.Commands
{
    public class GetSessionHistoryCommand : BaseRequestCommand
    {
        public string Service { get; set; }

        [RequestProperty(Format = "d")]
        public OtpStatusType Status { get; set; }

        public int Limit { get; set; }
        
        [RequestProperty(Format = "yyyy-MM-dd")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? FromDate { get; set; }
        
        [RequestProperty(Format = "yyyy-MM-dd")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime? ToDate { get; set; }
    }
}