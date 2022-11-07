using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.Commons;
using ViOtpApi.Helpers;
using ViOtpApi.Infrastructures;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Services
{
    public class SessionService : BaseService, ISessionService
    {
        public SessionService(string token) : base(token)
        {
        }

        public async Task<BaseResponseCommand<OtpResultResponseModel>> GetOtpFromRequestIdAsync(string requestId)
        {
            var command = new GetOtpFromRequestCommand()
            {
                Token = Token,
                RequestId = requestId
            };

            var result =
                await RestSharpHelper.RestClient.GetResultAsync<OtpResultResponseModel>(
                    RestSharpConstants.SessionEndpoint.GetOtpCode, command);

            return result;
        }

        public async Task<BaseListResponseModel<OtpResultResponseModel>> GetSessionHistoryAsync(GetSessionHistoryCommand command)
        {
            if (command != null)
            {
                command.Token = Token;
            }

            var result = await 
                RestSharpHelper.RestClient.GetListResultAsync<OtpResultResponseModel>(
                    RestSharpConstants.SessionEndpoint.RequestHistory, command);

            return result;
        }
    }
}