using Newtonsoft.Json;

namespace OneSignal {
    public class NotificationFilterEmail : NotificationFilter {
        public NotificationFilterEmail() {
            Field = "email";
            Key = "value";
        }

        /// <summary>
        /// Only for sending Push Notifications. To send emails to specific email addresses use IncludeEmailTokens parameter.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
        /// <summary>
        /// Only for sending Push Notifications. To send emails to specific email addresses use IncludeEmailTokens parameter.
        /// </summary>
        [JsonProperty("relation")]
        public string Relation { get; set; }
    }
}
