using Newtonsoft.Json;

namespace OneSignal {
    public class DeliveryStats {
        /// <summary>
        /// Number of notifications successfully delivered
        /// </summary>
        [JsonProperty("successful")]
        public int Successful { get; set; }

        /// <summary>
        /// Number of notifications that failed to deliver
        /// </summary>
        [JsonProperty("failed")]
        public int Failed { get; set; }

        /// <summary>
        /// Number of notifications that had an error sending
        /// </summary>
        [JsonProperty("errored")]
        public int Errored { get; set; }
    }
}
