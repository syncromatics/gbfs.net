using System.Runtime.Serialization;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Type of rental method
    /// </summary>
    /// <remarks>
    /// This list is intended to be as comprehensive at the time of publication as possible but is subject to change, as defined in File Requirements in the General Bikeshare Feed Specification 
    /// </remarks>
    public enum RentalMethodType
    {
        /// <summary>
        /// key
        /// </summary>
        [EnumMember(Value = "KEY")]
        Key,

        /// <summary>
        /// Credit card
        /// </summary>
        [EnumMember(Value = "CREDITCARD")]
        CreditCard,

        /// <summary>
        /// PayPass
        /// </summary>
        [EnumMember(Value = "PAYPASS")]
        PayPass,

        /// <summary>
        /// Apple Pay
        /// </summary>
        [EnumMember(Value = "APPLEPAY")]
        ApplePay,

        /// <summary>
        /// Android Pay
        /// </summary>
        [EnumMember(Value = "ANDROIDPAY")]
        AndroidPay,

        /// <summary>
        /// Transit card
        /// </summary>
        [EnumMember(Value = "TRANSITCARD")]
        TransitCard,

        /// <summary>
        /// Account number
        /// </summary>
        [EnumMember(Value = "ACCOUNTNUMBER")]
        AccountNumber,

        /// <summary>
        /// Phone
        /// </summary>
        [EnumMember(Value = "PHONE")]
        Phone,
    }
}