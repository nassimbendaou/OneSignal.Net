using Newtonsoft.Json;

namespace OneSignal {
    public class GenericResponse {
        /// <summary>
        /// Check if response was successful or not
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Id of the newly created object
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
