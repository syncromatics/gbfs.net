using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// A plan object.
    /// </summary>
    [Description("A plan object.")]
    public class PricingPlan
    {
        /// <summary>
        /// A unique identifier for this plan in the system
        /// </summary>
        [Description("A unique identifier for this plan in the system")]
        [JsonProperty(Required = Required.Always)]
        public string PlanId { get; set; }

        /// <summary>
        /// A fully qualified URL where the customer can learn more about this particular scheme
        /// </summary>
        [Description("A fully qualified URL where the customer can learn more about this particular scheme")]
        [JsonProperty(Required = Required.DisallowNull)]
        [Url]
        public string Url { get; set; }

        /// <summary>
        /// Name of this pricing scheme
        /// </summary>
        [Description("Name of this pricing scheme")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Currency this pricing is in (ISO 4217 code: http://en.wikipedia.org/wiki/ISO_4217)
        /// </summary>
        [Description("Currency this pricing is in (ISO 4217 code: http://en.wikipedia.org/wiki/ISO_4217)")]
        [JsonProperty(Required = Required.Always)]
        public string Currency { get; set; }

        /// <summary>
        /// Fee for this pricing scheme. This should be in the base unit as defined by the ISO 4217 currency code with the appropriate number of decimal places and omitting the currency symbol. e.g. if the price is in US Dollars the price would be 9.95
        /// </summary>
        [Description("Fee for this pricing scheme. This should be in the base unit as defined by the ISO 4217 currency code with the appropriate number of decimal places and omitting the currency symbol. e.g. if the price is in US Dollars the price would be 9.95")]
        [JsonProperty(Required = Required.Always)]
        public decimal Price { get; set; }

        /// <summary>
        /// <list>
        ///   <item>
        ///     <term><c>true</c></term>
        ///     <description>Indicates that no additional tax will be added (either because tax is not charged, or because it is included)</description>
        ///   </item> 
        ///   <item>
        ///     <term><c>false</c></term>
        ///     <description>Indicates that tax will be added to the base price</description>
        ///   </item>
        /// </list>
        /// </summary>
        [JsonIgnore]
        public bool IsTaxable { get; set; }

        [Description(@"1/0 value:
        0 indicates that no additional tax will be added (either because tax is not charged, or because it is included)
        1 indicates that tax will be added to the base price")]
        [JsonProperty("is_taxable", Required = Required.Always)]
        private int _isTaxable {get;set;}

        /// <summary>
        /// Text field describing the particular pricing plan in human readable terms.  This should include the duration, price, conditions, etc. that the publisher would like users to see. This is intended to be a human-readable description and should not be used for automatic calculations
        /// </summary>
        [Description("Text field describing the particular pricing plan in human readable terms.  This should include the duration, price, conditions, etc. that the publisher would like users to see. This is intended to be a human-readable description and should not be used for automatic calculations")]
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

    }
}