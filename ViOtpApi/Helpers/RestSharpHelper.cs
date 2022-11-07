using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using ViOtpApi.Abstractions;
using ViOtpApi.Commons;

namespace ViOtpApi.Helpers
{
    public static class RestSharpHelper
    {
        public static RestClient RestClient = new RestClient(RestSharpConstants.BaseUrl)
            .UseNewtonsoftJson(new JsonSerializerSettings()
            {
                // ContractResolver = new DefaultContractResolver()
                // {
                //     NamingStrategy = new SnakeCaseNamingStrategy()
                // },
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<Newtonsoft.Json.JsonConverter>() { new StringEnumConverter() },
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.None,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            });

        public static async Task<BaseResponseCommand<TResponse>> GetResultAsync<TResponse>(this RestClient restClient,
            string requestUrl,
            BaseRequestCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var response =
                await restClient.GetJsonAsync<BaseResponseCommand<TResponse>>(requestUrl, command, cancellationToken);

            return response;
        }
        
        public static async Task<BaseListResponseModel<TResponse>> GetListResultAsync<TResponse>(this RestClient restClient,
            string requestUrl,
            BaseRequestCommand command, CancellationToken cancellationToken = new CancellationToken())
        {
            var response =
                await restClient.GetJsonAsync<BaseListResponseModel<TResponse>>(requestUrl, command, cancellationToken);

            return response;
        }
    }
}