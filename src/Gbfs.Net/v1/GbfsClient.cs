using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;

namespace Gbfs.Net.v1
{
    public static class GbfsClient
    {
        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(),
            },
        };

        /// <summary>
        /// Gets an instance of the <see cref="IGbfsApi" /> based on a particular GBFS manifest
        /// </summary>
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
