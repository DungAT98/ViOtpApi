using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Infrastructures
{
    public interface IUserService
    {
        Task<BaseResponseCommand<UserBalanceResponseModel>> GetUserBalanceAsync();
    }
}