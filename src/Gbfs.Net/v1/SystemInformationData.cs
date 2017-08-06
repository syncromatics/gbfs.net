using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system including System operator, System location, year implemented, URLs, contact info, time zone.
    /// </summary>
    [Description("Describes the system including System operator, System location, year implemented, URLs, contact info, time zone.")]
    public class SystemInformationData
    {
        /// <summary>
        /// ID field - identifier for this bike share system. This should be globally unique (even between different systems) and it is currently up to the publisher of the feed to guarantee uniqueness. In addition, this value is intended to remain the same over the life of the system
        /// </summary>
        [Description("ID field - identifier for this bike share system. This should be globally unique (even between different systems) and it is currently up to the publisher of the feed to guarantee uniqueness. In addition, this value is intended to remain the same over the life of the system")]
        [JsonProperty(Required = Required.Always)]
        public string SystemId { get; set; }

        /// <summary>
        /// An IETF language tag indicating the language that will be used throughout the rest of the files. This is a string that defines a single language tag only. See https://tools.ietf.org/html/bcp47 and https://en.wikipedia.org/wiki/IETF_language_tag for details about the format of this tag
        /// </summary>
        [Description("An IETF language tag indicating the language that will be used throughout the rest of the files. This is a string that defines a single language tag only. See https://tools.ietf.org/html/bcp47 and https://en.wikipedia.org/wiki/IETF_language_tag for details about the format of this tag")]
        [JsonProperty(Required = Required.Always)]
        public string Language { get; set; }

        /// <summary>
        /// Full name of the system to be displayed to customers
        /// </summary>
        [Description("Full name of the system to be displayed to customers")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Abbreviation for a system
        /// </summary>
        [Description("Abbreviation for a system")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string ShortName { get; set; }

        /// <summary>
        /// Name of the operator of the system
        /// </summary>
        [Description("Name of the operator of the system")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Operator { get; set; }

        /// <summary>
        /// The URL of the bike share system. The value must be a fully qualified URL that includes http:// or https://, and any special characters in the URL must be correctly escaped. See http://www.w3.org/Addressing/URL/4_URI_Recommentations.html for a description of how to create fully qualified URL values
        /// </summary>
        [Description("The URL of the bike share system. The value must be a fully qualified URL that includes http:// or https://, and any special characters in the URL must be correctly escaped. See http://www.w3.org/Addressing/URL/4_URI_Recommentations.html for a description of how to create fully qualified URL values")]
        [JsonProperty(Required = Required.DisallowNull)]
        [Url]
        public string Url { get; set; }

        /// <summary>
        /// A fully qualified URL where a customer can purchase a membership or learn more about purchasing memberships
        /// </summary>
        [Description("A fully qualified URL where a customer can purchase a membership or learn more about purchasing memberships")]
        [JsonProperty(Required = Required.DisallowNull)]
        [Url]
        public string PurchaseUrl { get; set; }

        /// <summary>
        /// String in the form YYYY-MM-DD representing the date that the system began operations
        /// </summary>
        [Description("String in the form YYYY-MM-DD representing the date that the system began operations")]
        [JsonProperty(Required = Required.DisallowNull)]
        [RegularExpression(@"\d{4}-(0[1-9]|1[0-2])-([0-2][0-9]|3[0-1])")]
        public string StartDate { get; set; }

        /// <summary>
        /// A single voice telephone number for the specified system. This field is a string value that presents the telephone number as typical for the system's service area. It can and should contain punctuation marks to group the digits of the number. Dialable text (for example, Capital Bikeshare’s  "877-430-BIKE") is permitted, but the field must not contain any other descriptive text
        /// </summary>
        [Description("A single voice telephone number for the specified system. This field is a string value that presents the telephone number as typical for the system's service area. It can and should contain punctuation marks to group the digits of the number. Dialable text (for example, Capital Bikeshare’s  \"877-430-BIKE\") is permitted, but the field must not contain any other descriptive text")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// A single contact email address for customers to address questions about the system
        /// </summary>
        [Description("A single contact email address for customers to address questions about the system")]
        [JsonProperty(Required = Required.DisallowNull)]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The time zone where the system is located. Time zone names never contain the space character but may contain an underscore. Please refer to the "TZ" value in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones for a list of valid values
        /// </summary>
        [Description("The time zone where the system is located. Time zone names never contain the space character but may contain an underscore. Please refer to the \"TZ\" value in https://en.wikipedia.org/wiki/List_of_tz_database_time_zones for a list of valid values")]
        [JsonProperty(Required = Required.Always)]
        public string Timezone { get; set; }

        /// <summary>
        /// A fully qualified URL of a page that defines the license terms for the GBFS data for this system, as well as any other license terms the system would like to define (including the use of corporate trademarks, etc)
        /// </summary>
        [Description("A fully qualified URL of a page that defines the license terms for the GBFS data for this system, as well as any other license terms the system would like to define (including the use of corporate trademarks, etc)")]
        [JsonProperty(Required = Required.DisallowNull)]
        [Url]
        public string LicenseUrl { get; set; }

    }
}