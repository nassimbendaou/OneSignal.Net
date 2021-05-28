using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterAppVersion : NotificationFilter {
        public NotificationFilterAppVersion() {
            Field = "app_version";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("relation")]
        public RelationType Relation { get; set; }

        /// <summary>
        /// App version. Example: "1.0.0"
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        public enum RelationType {
            [EnumMember(Value = ">")]
            GreaterThan,
            [EnumMember(Value = "<")]
            LessThan,
            [EnumMember(Value = "=")]
            EqualTo,
            [EnumMember(Value = "!=")]
            NotEqualTo
        }
    }
}
