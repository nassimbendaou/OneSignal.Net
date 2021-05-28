using Newtonsoft.Json;

namespace OneSignal {
    public abstract class NotificationFilter {
        [JsonProperty("field")]
        public string Field { get; protected set; }
    }
}
