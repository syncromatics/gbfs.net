using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// The feeds in a language that all of the contained files will be published in. This language must match the value in the system_information file.
    /// </summary>
    [Description("The feeds in a language that all of the contained files will be published in. This language must match the value in the system_information file.")]
    public class ManifestFeeds
    {
        /// <summary>
        /// An array of all of the feeds that are published by this auto-discovery file
        /// </summary>
        [Description("An array of all of the feeds that are published by this auto-discovery file")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(3)]
        public List<Feed> Feeds { get; set; } = new List<Feed>();
    }
}