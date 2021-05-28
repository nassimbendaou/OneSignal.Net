using Newtonsoft.Json;

namespace OneSignal {
    public class PlatformDeliveryStats {
        /// <summary>
        /// Delivery stats for Edge web push notifications
        /// </summary>
        [JsonProperty("edge_web_push")]
        public DeliveryStats EdgeWebPush { get; set; }

        /// <summary>
        /// Delivery stats for Chrome web push notifications
        /// </summary>
        [JsonProperty("chrome_web_push")]
        public DeliveryStats ChromeWebPush { get; set; }

        /// <summary>
        /// Delivery stats for Firefox web push notifications
        /// </summary>
        [JsonProperty("firefox_web_push")]
        public DeliveryStats FirefoxWebPush { get; set; }

        /// <summary>
        /// Delivery stats for Android push notifications
        /// </summary>
        [JsonProperty("android")]
        public DeliveryStats Android { get; set; }

        /// <summary>
        /// Delivery stats for Safari web push notifications
        /// </summary>
        [JsonProperty("safari_web_push")]
        public DeliveryStats SafariWebPush { get; set; }

        /// <summary>
        /// Delivery stats for iOS push notifications
        /// </summary>
        [JsonProperty("ios")]
        public DeliveryStats Ios { get; set; }
    }
}
