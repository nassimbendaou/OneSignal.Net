using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterLastSession : NotificationFilter {
        public NotificationFilterLastSession() {
            Field = "last_session";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("relation")]
        public RelationType Relation { get; set; }

        /// <summary>
        /// Number of hours before or after the users last session. Example: 1.1
        /// </summary>
        [JsonProperty("hours_ago")]
        public decimal HoursAgo { get; set; }

        public enum RelationType {
            [EnumMember(Value = ">")]
            GreaterThan,
            [EnumMember(Value = "<")]
            LessThan
        }
    }
}
