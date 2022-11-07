namespace ViOtpApi.Commons
{
    public struct RestSharpConstants
    {
        public const string BaseUrl = "https://api.viotp.com";

        public struct UserEndpoint
        {
            public const string UserBalance = "users/balance";
        }

        public struct NetworkEndpoint
        {
            public const string CellularNetwork = "networks/get";
        }
        
        public struct ApplicationEndpoint
        {
            public const string ApplicationSupported = "service/getv2";
        }
        
        public struct RequestEndpoint
        {
            public const string RequestPhoneNumber = "request/getv2";
        }
        
        public struct SessionEndpoint
        {
            public const string GetOtpCode = "session/getv2";
            
            public const string RequestHistory = "session/historyv2";
        }
    }
}