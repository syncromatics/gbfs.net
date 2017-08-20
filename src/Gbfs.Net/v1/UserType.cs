using System.Runtime.Serialization;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Type of user for which <see cref="RentalHours" /> apply
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// Member
        /// </summary>
        [EnumMember(Value = "member")]
        Member,

        /// <summary>
        /// Non-member
        /// </summary>
        [EnumMember(Value = "nonmember")]
        Nonmember,
    }
}