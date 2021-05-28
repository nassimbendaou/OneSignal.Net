using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterTag : NotificationFilter {
        public NotificationFilterTag() {
            Field = "tag";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("relation")]
        public RelationType Relation { get; set; }

        /// <summary>
        /// Tag key to compare.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Tag value to compare. Not required for "Exists" or "NotExists"
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
            NotEqualTo,
            [EnumMember(Value = "exists")]
            Exists,
            [EnumMember(Value = "not_exists")]
            NotExists,
            [EnumMember(Value = "time_elapsed_gt")]
            TimeElapsedGreaterThan,
            [EnumMember(Value = "time_elapsed_lt")]
            TimeElapsedLessThan
        }
    }
}
