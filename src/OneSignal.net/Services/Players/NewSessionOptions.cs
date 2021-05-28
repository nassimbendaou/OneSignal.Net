using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class NewSessionOptions : BaseOptions {
        /// <summary>
        /// Recommended: Push notification identifier from Google or Apple. For Apple push identifiers, you must strip all non alphanumeric characters.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Recommended: Language code. Typically lower case two letters, except for Chinese where it must be one of zh-Hans or zh-Hant. Example: en
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Recommended: Number of seconds away from UTC. Example: -28800
        /// </summary>
        [JsonProperty("timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// Recommended: Version of your app. Example: 1.1
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        /// <summary>
        /// Recommended: Device operating system version. Example: 7.0.4
        /// </summary>
        [JsonProperty("device_os")]
        public string DeviceOs { get; set; }

        /// <summary>
        /// Recommended: The ad id for the device's platform
        /// </summary>
        [JsonProperty("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// Name and version of sdk/plugin that's calling this method.
        /// </summary>
        [JsonProperty("sdk")]
        public string Sdk { get; private set; } = OneSignalConfiguration.GetSdkName();

        /// <summary>
        /// Custom tags for the player.
        /// </summary>
        [JsonProperty("tags")]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// If included, will create a new player record if the one is not found.
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceType? DeviceType { get; set; }
    }
}
