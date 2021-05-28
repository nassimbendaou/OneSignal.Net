using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class NotificationOutcomeResponse {
        /// <summary>
        /// A list of outcomes based on query parameters
        /// </summary>
        [JsonProperty("outcomes")]
        public List<NotificationOutcome> Outcomes { get; set; }
    }
}
