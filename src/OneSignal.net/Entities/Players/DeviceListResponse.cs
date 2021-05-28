using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class DeviceListResponse {
        /// <summary>
        /// Total count of the devices found
        /// </summary>
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// The current page offset
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Current max devices per page
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// List of the current page of players
        /// </summary>
        [JsonProperty("players")]
        public List<DeviceResponse> Players { get; set; }
    }
}
