using Newtonsoft.Json;

namespace OneSignal {
    public class NotificationOutcome {
        /// <summary>
        /// The name of the outcome
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Returned value of the aggregation type
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Aggregation type (sum or count) requested for the outcome
        /// </summary>
        [JsonProperty("aggregation")]
        public string Aggregation { get; set; }
    }
}
