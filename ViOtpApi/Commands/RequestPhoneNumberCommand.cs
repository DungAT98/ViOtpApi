using System;
using System.Collections.Generic;
using ViOtpApi.Abstractions;

namespace ViOtpApi.Commands
{
    public class RequestPhoneNumberCommand : BaseRequestCommand
    {
        public int ServiceId { get; set; }

        public string Network { get; set; }

        public List<int> Prefix { get; set; }

        public List<int> ExceptPrefix { get; set; }

        public string Number { get; set; }
    }
}