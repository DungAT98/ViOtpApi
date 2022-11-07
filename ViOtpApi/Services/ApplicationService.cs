using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.Commons;
using ViOtpApi.Helpers;
using ViOtpApi.Infrastructures;
using ViOtpApi.Models;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Services
{
    public class ApplicationService : BaseService, IApplicationService
    {
        public ApplicationService(string token) : base(token)
        {
        }

        public async Task<BaseListResponseModel<ProductResponseModel>> GetSupportedApplicationAsync(
            CountryType countryType = CountryType.Vietnam)
        {
            var request = new GetSupportedApplicationCommand()
            {
                Token = Token,
                Country = countryType
            };

            var result =
                await RestSharpHelper.RestClient.GetListResultAsync<ProductResponseModel>(
                    RestSharpConstants.ApplicationEndpoint.ApplicationSupported, request);

            return result;
        }
    }
}