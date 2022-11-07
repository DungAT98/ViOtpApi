using System.Runtime.Serialization;

namespace ViOtpApi.Models
{
    public enum CountryType
    {
        [EnumMember(Value = "vn")]
        Vietnam,

        [EnumMember(Value = "kh")]
        Cambodia
    }
}