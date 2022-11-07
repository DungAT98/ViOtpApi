using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Infrastructures
{
    public interface ISessionService
    {
        Task<BaseResponseCommand<OtpResultResponseModel>> GetOtpFromRequestIdAsync(string requestId);

        Task<BaseListResponseModel<OtpResultResponseModel>> GetSessionHistoryAsync(GetSessionHistoryCommand command);
    }
}