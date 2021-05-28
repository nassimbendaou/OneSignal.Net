using Newtonsoft.Json;

namespace OneSignal {
    public class NotificationFilterCountry : NotificationFilter {
        public NotificationFilterCountry() {
            Field = "country";
        }

        [JsonProperty("relation")]
        public string Relation { get { return "="; } }

        /// <summary>
        /// 2-digit Country code. Example: US
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}