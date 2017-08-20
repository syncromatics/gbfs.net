using System.Runtime.Serialization;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Type of <see cref="Alert" />
    /// </summary>
    public enum AlertType
    {
        /// <summary>
        /// System closure
        /// </summary>
        [EnumMember(Value = "SYSTEM_CLOSURE")]
        SystemClosure,

        /// <summary>
        /// Station closure
        /// </summary>
        [EnumMember(Value = "STATION_CLOSURE")]
        StationClosure,

        /// <summary>
        /// Station move
        /// </summary>
        [EnumMember(Value = "STATION_MOVE")]
        StationMove,

        /// <summary>
        /// Other
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,
    }
}