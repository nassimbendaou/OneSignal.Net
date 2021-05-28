using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class NewPurchaseOptions : BaseOptions {
        /// <summary>
        /// Required: A list of purchases
        /// </summary>
        [JsonProperty("purchases")]
        public List<Purchase> Purchases { get; set; }

        /// <summary>
        /// Pass true on the first run of your app if you're tracking existing non-consumable purchases. This prevents tracking the same purchases more than once if the user re-installs your app.
        /// </summary>
        [JsonProperty("existing")]
        public bool Existing { get; set; }
    }
}
