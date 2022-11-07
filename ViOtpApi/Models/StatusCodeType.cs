namespace ViOtpApi.Models
{
    public enum StatusCodeType
    {
        Success = 200,
        AuthenticationError = 401,
        Error = -1,
        LimitExceeded = 429,
        BalanceNotEnough = -2,
        DontHavePhoneNumber = -3,
        ApplicationNotFound = -4
    }
}