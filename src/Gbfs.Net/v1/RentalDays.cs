using System.Runtime.Serialization;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Day of week that <see cref="RentalHours" /> may apply
    /// </summary>
    public enum RentalDays
    {
        /// <summary>
        /// Sunday
        /// </summary>
        [EnumMember(Value = "sun")]
        Sunday,

        /// <summary>
        /// Monday
        /// </summary>
        [EnumMember(Value = "mon")]
        Monday,

        /// <summary>
        /// Tuesday
        /// </summary>
        [EnumMember(Value = "tue")]
        Tuesday,

        /// <summary>
        /// Wednesday
        /// </summary>
        [EnumMember(Value = "wed")]
        Wednesday,

        /// <summary>
        /// Thursday
        /// </summary>
        [EnumMember(Value = "thu")]
        Thursday,

        /// <summary>
        /// Friday
        /// </summary>
        [EnumMember(Value = "fri")]
        Friday,

        /// <summary>
        /// Saturday
        /// </summary>
        [EnumMember(Value = "sat")]
        Saturday,
    }
}