using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterSessionCount : NotificationFilter {
        public NotificationFilterSessionCount() {
            Field = "session_count";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("relation")]
        public RelationType Relation { get; set; }

        /// <summary>
        /// Number sessions. Example: 1
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }

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
