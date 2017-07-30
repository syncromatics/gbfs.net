using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describe pricing for the system.
    /// </summary>
    /// <remarks>
    /// This scheme does not currently factor in lost bike fees as it seems outside of the scope of this specification, but they could be added.
    /// </remarks>
    public class SystemPricingPlansData
    {
        /// <summary>
        /// Array of any number of plan objects.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public List<PricingPlan> Plans { get; set; } = new List<PricingPlan>();
    }
}