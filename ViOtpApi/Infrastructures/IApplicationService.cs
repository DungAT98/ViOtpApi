using System.Threading.Tasks;
using ViOtpApi.Abstractions;
using ViOtpApi.Models;
using ViOtpApi.ViewModels;

namespace ViOtpApi.Infrastructures
{
    public interface IApplicationService
    {
        Task<BaseListResponseModel<ProductResponseModel>> GetSupportedApplicationAsync(CountryType countryType);
    }
}