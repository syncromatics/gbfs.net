using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestEase;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Client to interact with a GBFS feed
    /// </summary>
    public static class GbfsClient
    {
        /// <summary>
        /// JSON serialization settings
        /// </summary>
        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy(),
            },
            Converters = {
                new StringEnumConverter(),
            }
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
