using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Commands;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Infrastructures
{
    public interface IRequestService
    {
        Task<BaseResponseCommand<RequestPhoneNumberResponseModel>>
            RequestNumberAsync(RequestPhoneNumberCommand command);
    }
}