using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OneSignal {
    public class NotificationFilterLanguage : NotificationFilter {
        public NotificationFilterLanguage() {
            Field = "language";
        }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("relation")]
        public RelationType Relation { get; set; }

        /// <summary>
        /// 2 character language code. Example: "en". For a list of all language codes see <a href="https://documentation.onesignal.com/docs/language-localization">Language & Localization</a>.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        public enum RelationType {
            [EnumMember(Value = "=")]
            EqualTo,
            [EnumMember(Value = "!=")]
            NotEqualTo
        }
    }
}
