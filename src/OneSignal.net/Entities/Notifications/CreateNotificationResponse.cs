using Newtonsoft.Json;

namespace OneSignal {
    public class CreateNotificationResponse {
        /// <summary>
        /// The id of the newly created notification
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The number of players that the notification was sent to
        /// </summary>
        [JsonProperty("recipients")]
        public int Recipients { get; set; }

        /// <summary>
        /// The external id of the notification
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Any invalid player id or external user ids found for the notification
        /// </summary>
        [JsonProperty("errors")]
        [JsonConverter(typeof(CreateNotificationErrorsConverter))]
        public CreateNotificationErrors Errors { get; set; }
    }
}
