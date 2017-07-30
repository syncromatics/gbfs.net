using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// An hour object
    /// </summary>
    public class RentalHours
    {
        /// <summary>
        /// An array of "member" and "nonmember" values. This indicates that this set of rental hours applies to either members or non-members only.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public List<string> UserTypes { get; set; }

        /// <summary>
        /// An array of abbreviations (first 3 letters) of English names of the days of the week that this hour object applies to (i.e. ["mon", "tue"]). Each day can only appear once within all of the hours objects in this feed.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public List<string> Days { get; set; }

        /// <summary>
        /// Start time for the hours of operation of the system in the time zone indicated in <see cref="SystemInformation" />  (00:00:00 - 23:59:59)
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string StartTime { get; set; }

        /// <summary>
        /// End time for the hours of operation of the system in the time zone indicated in <see cref="SystemInformation" /> (00:00:00 - 47:59:59). Time can stretch up to one additional day in the future to accommodate situations where, for example, a system was open from 11:30pm - 11pm the next day (i.e. 23:30-47:00)
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string EndTime { get; set; }
    }
}