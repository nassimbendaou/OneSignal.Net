using Newtonsoft.Json;

namespace OneSignal {
    public class NotificationFilterLocation : NotificationFilter {
        public NotificationFilterLocation() {
            Field = "location";
        }

        /// <summary>
        /// Radius in meters
        /// </summary>
        [JsonProperty("radius")]
        public decimal Radius { get; set; }
        
        [JsonProperty("lat")]
        public decimal Latitude { get; set; }
        
        [JsonProperty("long")]
        public decimal Longitude { get; set; }
    }
}
