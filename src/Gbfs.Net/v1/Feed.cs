namespace Gbfs.Net.v1
{
    /// <sumamry>
    /// A feed published by this auto-discovery file
    /// </sumamry>
    public class Feed
    {
        /// <summary>
        /// Key identifying the type of feed this is. (e.g. "system_information", "station_information")
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Full URL for the feed.
        /// </summary>
        public string Url { get; set; }
    }
}