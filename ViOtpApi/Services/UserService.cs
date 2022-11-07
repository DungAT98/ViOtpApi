using System.Threading.Tasks;
using RestSharp;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.Commons;
using ViOtpApi.Helpers;
using ViOtpApi.Infrastructures;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(string token) : base(token)
        {
        }
        
        public async Task<BaseResponseCommand<UserBalanceResponseModel>> GetUserBalanceAsync()
        {
            var request = new GetUserBalanceCommand()
            {
                Token = Token
            };

            var result =
                await RestSharpHelper.RestClient.GetResultAsync<UserBalanceResponseModel>(
                    RestSharpConstants.UserEndpoint.UserBalance, request);

            return result;
        }
    }
}