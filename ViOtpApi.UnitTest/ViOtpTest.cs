using System;
using System.Threading.Tasks;
using ViOtpApi.Commands;
using ViOtpApi.Infrastructures;
using ViOtpApi.Models;
using ViOtpApi.Services;
using Xunit;

namespace ViOtpApi.UnitTest;

public class ViOtpTest
{
    public IViOtpService ViOtpService { get; set; }
    
    public ViOtpTest()
    {
        ViOtpService = new ViOtpService("8c700df1d69443b39f4f2b392d300ca4");
    }

    [Fact]
    public async Task GetUserBalance()
    {
        var result = await ViOtpService.UserService.GetUserBalanceAsync();
    }
    
    [Fact]
    public async Task GetSupportedApplication()
    {
        var result = await ViOtpService.ApplicationService.GetSupportedApplicationAsync(CountryType.Vietnam);
    }
    
    [Fact]
    public async Task RequestPhoneNumber()
    {
        var command = new RequestPhoneNumberCommand()
        {
            ServiceId = 361
        };
        
        var result = await ViOtpService.RequestService.RequestNumberAsync(command);
    }
    
    [Fact]
    public async Task GetSessionHistory()
    {
        var command = new GetSessionHistoryCommand()
        {
            FromDate = DateTime.Now.AddDays(-1),
            ToDate = DateTime.Now,
            Limit = 100,
            Service = "361",
            Status = OtpStatusType.Expired
        };
        
        var result = await ViOtpService.SessionService.GetSessionHistoryAsync(command);
    }
}