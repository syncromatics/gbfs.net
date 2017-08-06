using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// An hour object
    /// </summary>
    [Description("An hour object")]
    public class RentalHours
    {
        /// <summary>
        /// An array of "member" and "nonmember" values. This indicates that this set of rental hours applies to either members or non-members only.
        /// </summary>
        [Description("An array of \"member\" and \"nonmember\" values. This indicates that this set of rental hours applies to either members or non-members only.")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(1)]
        [MaxLength(2)]
        public List<UserType> UserTypes { get; set; } = new List<UserType>();

        /// <summary>
        /// An array of abbreviations (first 3 letters) of English names of the days of the week that this hour object applies to (i.e. ["mon", "tue"]). Each day can only appear once within all of the hours objects in this feed.
        /// </summary>
        [Description("An array of abbreviations (first 3 letters) of English names of the days of the week that this hour object applies to (i.e. [\"mon\", \"tue\"]). Each day can only appear once within all of the hours objects in this feed.")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(1)]
        [MaxLength(7)]
        public List<RentalDays> Days { get; set; } = new List<RentalDays>();

        /// <summary>
        /// Start time for the hours of operation of the system in the time zone indicated in <see cref="SystemInformation" /> (00:00:00 - 23:59:59)
        /// </summary>
        [Description("Start time for the hours of operation of the system in the time zone indicated in system_information (00:00:00 - 23:59:59)")]
        [JsonProperty(Required = Required.Always)]
        [RegularExpression(@"([0-1][0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]")]
        public string StartTime { get; set; }

        /// <summary>
        /// End time for the hours of operation of the system in the time zone indicated in <see cref="SystemInformation" /> (00:00:00 - 47:59:59). Time can stretch up to one additional day in the future to accommodate situations where, for example, a system was open from 11:30pm - 11pm the next day (i.e. 23:30-47:00)
        /// </summary>
        [Description("End time for the hours of operation of the system in the time zone indicated in system_information (00:00:00 - 47:59:59). Time can stretch up to one additional day in the future to accommodate situations where, for example, a system was open from 11:30pm - 11pm the next day (i.e. 23:30-47:00)")]
        [JsonProperty(Required = Required.Always)]
        [RegularExpression(@"([0-3][0-9]|4[0-7]):[0-5][0-9]:[0-5][0-9]")]
        public string EndTime { get; set; }
    }
}