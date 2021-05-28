using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class CreateNotificationErrors {
        /// <summary>
        /// List of invalid external user ids that can be removed from your database
        /// </summary>
        [JsonProperty("invalid_external_user_ids")]
        public List<string> InvalidExternalUserIds { get; set; }

        /// <summary>
        /// List of invalid player ids that can be removed from your database
        /// </summary>
        [JsonProperty("invalid_player_ids")]
        public List<string> InvalidPlayerIds { get; set; }

        [JsonIgnore]
        public List<string> ErrorMessages { get; set; }
    }
}
