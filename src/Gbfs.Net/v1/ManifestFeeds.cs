using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// The feeds in a language that all of the contained files will be published in. This language must match the value in the system_information file.
    /// </summary>
    public class ManifestFeeds
    {
        /// <summary>
        /// An array of all of the feeds that are published by this auto-discovery file
        /// </summary>
        public List<Feed> Feeds { get; set; }
    }
}