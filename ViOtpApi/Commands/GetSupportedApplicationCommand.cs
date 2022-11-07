using Newtonsoft.Json;
using ViOtpApi.Abstractions;
using ViOtpApi.Models;

namespace ViOtpApi.Commands
{
    public class GetSupportedApplicationCommand : BaseRequestCommand
    {
        public CountryType Country { get; set; }
    }
}