using System;
using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Auto-discovery file that links to all of the other files published by the system.
    /// </summary>
    /// <remarks>
    /// This file is optional, but highly recommended.
    /// </remarks>
    public class Manifest : GbfsFile<Dictionary<string, ManifestFeeds>>
    {
        /// <summary>
        /// Dictionary keyed by language that all of the contained files will be published in. This language must match the value in the <c>system_information</c> file.
        /// </summary>
        public override Dictionary<string, ManifestFeeds> Data { get; set; }
    }
}