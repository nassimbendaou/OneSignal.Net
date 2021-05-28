using Newtonsoft.Json;

namespace OneSignal {
    public class GetNotificationHistoryResponse {
        /// <summary>
        /// Status of request
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// URl to the file that can be downloaded that contains the notification history
        /// </summary>
        [JsonProperty("destination_url")]
        public string DestinationUrl { get; set; }
    }
}
