## ViOtp API Adapter for .NET application

## If anything changed, feel free to create a pull request. Anything will be appreciated

First, we need to create a service

``var viOtpService = new ViOtpService("[Enter your token here]");``

That's all. Now we call the api that we need to use

### Get User Balance

``var result = await viOtpService.UserService.GetUserBalanceAsync();``

## GetSupportedApplication

``var result = await viOtpService.ApplicationService.GetSupportedApplicationAsync(CountryType.Vietnam);``

## Get Phone number

````
var command = new RequestPhoneNumberCommand()
{
    ServiceId = 361
};

var result = await ViOtpService.RequestService.RequestNumberAsync(command);
````

## Get Session history

````
var command = new GetSessionHistoryCommand()
{
    FromDate = DateTime.Now.AddDays(-1),
    ToDate = DateTime.Now,
    Limit = 100,
    Service = "361",
    Status = OtpStatusType.Expired
};

var result = await ViOtpService.SessionService.GetSessionHistoryAsync(command);
````

## More information, please refer my Unit Test