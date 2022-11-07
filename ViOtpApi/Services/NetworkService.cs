using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.Commons;
using ViOtpApi.Helpers;
using ViOtpApi.Infrastructures;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Services
{
    public class NetworkService : BaseService,  INetworkService
    {
        public async Task<BaseListResponseModel<NetworkResponseModel>> GetListCellularNetworkAsync()
        {
            var request = new GetNetworkListCommand()
            {
                Token = Token
            };

            var result =
                await RestSharpHelper.RestClient.GetListResultAsync<NetworkResponseModel>(
                    RestSharpConstants.NetworkEndpoint.CellularNetwork, request);

            return result;
        }

        public NetworkService(string token) : base(token)
        {
        }
    }
}