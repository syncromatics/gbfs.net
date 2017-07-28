using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;

namespace Gbfs.Net
{
    public class GbfsApi
    {
        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(),
            },
        };

        public static IGbfsApi GetInstance(string url)
        {
            var api = new RestClient(url)
            {
                JsonSerializerSettings = JsonSerializerSettings
            }.For<IGbfsApi>();

            return api;
        }
    }
}
