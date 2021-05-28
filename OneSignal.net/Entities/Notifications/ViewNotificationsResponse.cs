using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class ViewNotificationsResponse {
        /// <summary>
        /// Total count of found notifications
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Current page offset
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Current page limit
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// List of notifications for the current page
        /// </summary>
        [JsonProperty("notifications")]
        public List<NotificationResponse> Notifications { get; set; }
    }
}
