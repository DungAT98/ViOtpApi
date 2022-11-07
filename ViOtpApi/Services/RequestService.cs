using System.Threading;
using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.Commons;
using ViOtpApi.Helpers;
using ViOtpApi.Infrastructures;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Services
{
    public class RequestService : BaseService, IRequestService
    {
        public RequestService(string token) : base(token)
        {
        }

        public async Task<BaseResponseCommand<RequestPhoneNumberResponseModel>> RequestNumberAsync(
            RequestPhoneNumberCommand command)
        {
            if (command != null)
            {
                command.Token = Token;
            }
            
            var result = await
                RestSharpHelper.RestClient.GetResultAsync<RequestPhoneNumberResponseModel>(
                    RestSharpConstants.RequestEndpoint.RequestPhoneNumber, command);

            return result;
        }
    }
}