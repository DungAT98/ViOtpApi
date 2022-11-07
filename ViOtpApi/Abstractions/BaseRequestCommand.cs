using Newtonsoft.Json;

namespace ViOtpApi.Abstractions
{
    public abstract class BaseRequestCommand
    {
        public string Token { get; set; }
    }
}