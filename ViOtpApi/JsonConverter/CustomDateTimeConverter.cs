using Newtonsoft.Json.Converters;

namespace ViOtpApi.JsonConverter
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}