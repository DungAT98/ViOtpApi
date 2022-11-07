namespace ViOtpApi.Infrastructures
{
    public interface IViOtpService
    {
        IUserService UserService { get; set; }
        
        INetworkService NetworkService { get; set; }
        
        IApplicationService ApplicationService { get; set; }
        
        IRequestService RequestService { get; set; }
        
        ISessionService SessionService { get; set; }
    }
}