using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace OneSignal {
    public class CreateUpdateDeviceOptions : BaseOptions {
        /// <summary>
        /// Your OneSignal App Id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; private set; }

        /// <summary>
        /// The device's platform
        /// </summary>
        [JsonProperty("device_type")]
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Only required if you have enabled <a href="https://documentation.onesignal.com/docs/identity-verification">Identity Verification</a> and device_type is 11 email.
        /// </summary>
        [JsonProperty("email_auth_hash")]
        public string EmailAuthHash { get; set; }

        /// <summary>
        /// <para>Recommended: For Push Notifications, this is the Push Token Identifier from Google or Apple. For Apple Push identifiers, you must strip all non alphanumeric characters.</para>
        /// <para>iOS: 7abcd558f29d0b1f048083e2834ad8ea4b3d87d8ad9c088b33c132706ff445f0</para>
        /// <para>Android:APA91bHbYHk7aq-Uam_2pyJ2qbZvqllyyh2wjfPRaw5gLEX2SUlQBRvOc6sck1sa7H7nGeLNlDco8lXj83HWWwzV...</para>
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>This is used in deciding whether to use your iOS Sandbox or Production push certificate when sending a push when both have been uploaded. Set to the iOS provisioning profile that was used to build your app.</para>
        /// <para>Omit this field for App Store builds.</para>
        /// </summary>
        [JsonProperty("test_type")]
        public TestType? TestType { get; set; }

        /// <summary>
        /// Recommended: Language code. Typically lower case two letters, except for Chinese where it must be one of zh-Hans or zh-Hant. Example: en
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Recommended: Number of seconds away from UTC. Example: -28800
        /// </summary>
        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        /// <summary>
        /// Recommended: Version of your app. Example: 1.1
        /// </summary>
        [JsonProperty("game_version")]
        public string GameVersion { get; set; }

        /// <summary>
        /// Recommended: Device make and model. Example: iPhone5,1
        /// </summary>
        [JsonProperty("device_model")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Recommended: Device operating system version. Example: 7.0.4
        /// </summary>
        [JsonProperty("device_os")]
        public string DeviceOs { get; set; }

        /// <summary>
        /// The ad id for the device's platform
        /// </summary>
        [JsonProperty("ad_id")]
        public string AdId { get; set; }

        /// <summary>
        /// Recommended: Name and version of the plugin that's calling this API method (if any)
        /// </summary>
        [JsonProperty("sdk")]
        public string Sdk { get; private set; } = OneSignalConfiguration.GetSdkName();

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
        [JsonConverter(typeof(DecimalFormatConverter))]
        [JsonProperty("amount_spent")]
        public decimal AmountSpent { get; set; }

        /// <summary>
        /// Unix timestamp indicating date and time when the player joined the app/site.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Seconds player was running your app.
        /// </summary>
        [JsonProperty("playtime")]
        public int Playtime { get; set; }

        /// <summary>
        /// Date and time when the player was last active.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("last_active")]
        public int LastActive { get; set; }

        /// <summary>
        /// <para>iOS - These values are set each time the user opens the app from the SDK. Use the SDK function set Subscription instead.</para>
        /// <para>Android - You may set this but you can no longer use the SDK method setSubscription later in your app as it will create synchronization issues.</para>
        /// </summary>
        [JsonProperty("notification_types")]
        public NotificationType? NotificationType { get; set; }

        /// <summary>
        /// Longitude of the device, used for geotagging to segment on.
        /// </summary>
        [JsonProperty("long")]
        public double Longitude { get; set; }

        /// <summary>
        /// Latitude of the device, used for geotagging to segment on.
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Country code in the ISO 3166-1 Alpha 2 format. Example: US
        /// </summary>
        [JsonProperty("country")]
        public string CountryCode { get; set; }

        /// <summary>
        /// A custom user ID
        /// </summary>
        [JsonProperty("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// Only required if you have enabled <a href="https://documentation.onesignal.com/docs/identity-verification">Identity Verification</a> and device_type is NOT 11 email.
        /// </summary>
        [JsonProperty("external_user_id_auth_hash")]
        public string ExternalUserIdAuthHash { get; set; }

        public CreateUpdateDeviceOptions(string appId = null) {
            AppId = appId ?? OneSignalConfiguration.GetAppId();
        }
    }
}
