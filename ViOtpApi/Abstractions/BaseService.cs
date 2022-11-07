namespace ViOtpApi.Abstractions
{
    public abstract class BaseService
    {
        protected string Token { get; }

        protected BaseService(string token)
        {
            Token = token;
        }
    }
}