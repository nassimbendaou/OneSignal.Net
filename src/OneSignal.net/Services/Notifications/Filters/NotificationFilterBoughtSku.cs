using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterBoughtSku : NotificationFilter {
        public NotificationFilterBoughtSku() {
            Field = "bought_sku";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public RelationType Relation { get; set; }

        /// <summary>
        /// SKU purchased in your app as an IAP (In App Purchases). Example: "com.domain.100coinpack"
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Value of SKU to compare to. Example: 0.99
        /// </summary>
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
