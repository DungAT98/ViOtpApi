using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Infrastructures
{
    public interface INetworkService
    {
        Task<BaseListResponseModel<NetworkResponseModel>> GetListCellularNetworkAsync();
    }
}