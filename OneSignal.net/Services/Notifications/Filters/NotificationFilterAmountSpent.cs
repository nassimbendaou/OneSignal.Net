using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterAmountSpent : NotificationFilter {
        public NotificationFilterAmountSpent() {
            Field = "amount_spent";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("relation")]
        public RelationType Relation { get; set; }

        /// <summary>
        /// Amount in USD a user has spent on IAP (In App Purchases). Example: 0.99
        /// </summary>
        [JsonConverter(typeof(DecimalFormatConverter))]
        [JsonProperty("value")]
        public decimal Value { get; set; }

        public enum RelationType {
            [EnumMember(Value = ">")]
            GreaterThan,
            [EnumMember(Value = "<")]
            LessThan,
            [EnumMember(Value = "=")]
            EqualTo
        }
    }
}
