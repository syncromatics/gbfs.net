namespace Gbfs.Net.v1
{
    /// <summary>
    /// Represents the common format of GBFS data
    /// </summary>
    public interface IGbfsFile<T>
    {
        /// <summary>
        /// Integer POSIX timestamp indicating the last time the data in this feed was updated
        /// </summary>
        long LastUpdated { get; set; }

        /// <summary>
        /// Integer representing the number of seconds before the data in this feed will be updated again (0 if the data should always be refreshed)
        /// </summary>
        long TimeToLive { get; set; }

        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        T Data { get; set; }
    }
}