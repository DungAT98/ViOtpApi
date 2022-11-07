using ViOtpApi.Infrastructures;

namespace ViOtpApi.Services
{
    public class ViOtpService : IViOtpService
    {
        private readonly string _token;

        public ViOtpService(string token)
        {
            _token = token;
        }

        public IUserService UserService
        {
            get => _userService ?? (_userService = new UserService(_token));
            set => _userService = value;
        }

        public INetworkService NetworkService
        {
            get => _networkService ?? (_networkService = new NetworkService(_token));
            set => _networkService = value;
        }

        public IApplicationService ApplicationService
        {
            get => _applicationService ?? (_applicationService = new ApplicationService(_token));
            set => _applicationService = value;
        }
        
        public IRequestService RequestService
        {
            get => _requestService ?? (_requestService = new RequestService(_token));
            set => _requestService = value;
        }

        public ISessionService SessionService 
        {
            get => _sessionService ?? (_sessionService = new SessionService(_token));
            set => _sessionService = value;
        }

        private ISessionService _sessionService;

        private IApplicationService _applicationService;

        private IUserService _userService;

        private INetworkService _networkService;

        private IRequestService _requestService;
    }
}