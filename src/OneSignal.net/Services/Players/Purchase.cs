using Newtonsoft.Json;

namespace OneSignal {
    public class Purchase {
        /// <summary>
        /// Required: The unique identifier of the purchased item.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Required: The amount, in USD, spent purchasing the item.
        /// </summary>
        [JsonConverter(typeof(DecimalFormatConverter))]
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Required: The 3-letter ISO 4217 currency code. Required for correct storage and conversion of amount.
        /// </summary>
        [JsonProperty("iso")]
        public string Iso { get; set; }
    }
}
