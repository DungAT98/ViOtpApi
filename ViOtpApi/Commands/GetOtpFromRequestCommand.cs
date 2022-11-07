using ViOtpApi.Abstractions;

namespace ViOtpApi.Commands
{
    public class GetOtpFromRequestCommand : BaseRequestCommand
    {
        public string RequestId { get; set; }
    }
}