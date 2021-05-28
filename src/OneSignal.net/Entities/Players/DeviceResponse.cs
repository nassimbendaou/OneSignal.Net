using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace OneSignal {
    public class DeviceResponse {
        /// <summary>
        /// The device's platform
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// <para>For Push Notifications, this is the Push Token Identifier from Google or Apple.</para>
        /// <para>iOS: 7abcd558f29d0b1f048083e2834ad8ea4b3d87d8ad9c088b33c132706ff445f0</para>
        /// <para>Android:APA91bHbYHk7aq-Uam_2pyJ2qbZvqllyyh2wjfPRaw5gLEX2SUlQBRvOc6sck1sa7H7nGeLNlDco8lXj83HWWwzV...</para>
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Language code. Typically lower case two letters, except for Chinese where it must be one of zh-Hans or zh-Hant. Example: en
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Number of seconds away from UTC. Example: -28800
        /// </summary>
        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        /// <summary>
        /// Version of your app. Example: 1.1
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        /// <summary>
        /// Device make and model. Example: iPhone5,1
        /// </summary>
        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Device operating system version. Example: 7.0.4
        /// </summary>
        [JsonProperty("device_os")]
        public string DeviceOs { get; set; }

        /// <summary>
        /// The ad id for the device's platform
        /// </summary>
        [JsonProperty("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// Number of times the user has played the game, defaults to 1
        /// </summary>
        [JsonProperty("session_count")]
        public int SessionCount { get; set; }

        /// <summary>
        /// Custom tags for the player.
        /// </summary>
        [JsonProperty("tags")]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Amount the user has spent in USD, up to two decimal places
        /// </summary>
        [JsonProperty("amount_spent")]
        public decimal AmountSpent { get; set; }

        /// <summary>
        /// Unix timestamp indicating date and time when the player joined the app/site.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date and time when the player was last active.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("last_active")]
        public int LastActive { get; set; }

        /// <summary>
        /// A custom user ID
        /// </summary>
        [JsonProperty("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Indicates if the identifier is invalid
        /// </summary>
        [JsonProperty("invalid_identifier")]
        public bool InvalidIdentifier { get; set; }

        /// <summary>
        /// Badge count for the player
        /// </summary>
        [JsonProperty("badge_count")]
        public int BadgeCount { get; set; }
    }
}
