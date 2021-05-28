using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class OneSignalError {
        /// <summary>
        /// Success status
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// List of errors for the request
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
    }
}
