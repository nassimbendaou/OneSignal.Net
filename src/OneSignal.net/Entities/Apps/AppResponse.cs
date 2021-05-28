using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace OneSignal {
    public class AppResponse {
        /// <summary>
        /// The newly created app id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Required: The name of your new app, as displayed on your apps list on the dashboard. This can be renamed later.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of players subscribed to your app
        /// </summary>
        [JsonProperty("players")]
        public int Players { get; set; }

        /// <summary>
        /// Number of players subscribed to your app that can be messaged
        /// </summary>
        [JsonProperty("messageable_players")]
        public int MessageablePlayers { get; set; }

        /// <summary>
        /// Date your app was last updated in UTC
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Date your app was created in UTC
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// iOS: Either sandbox or production
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("apns_env")]
        public ApnsEnvironment ApnsEnvironment { get; set; }

        /// <summary>
        /// iOS: Your apple push notification certificate files converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("apns_certificates")]
        public string ApnsCertificates { get; set; }

        /// <summary>
        /// Android: Your Google Push Messaging Auth Key
        /// </summary>
        [JsonProperty("gcm_key")]
        public string GcmKey { get; set; }

        /// <summary>
        /// Chrome (All Browsers except Safari) (Recommended): The URL to your website. This field is required if you wish to enable web push and specify other web push parameters.
        /// </summary>
        [JsonProperty("chrome_web_origin")]
        public string ChromeWebOrigin { get; set; }

        /// <summary>
        /// Chrome (All Browsers except Safari): Your default notification icon. Should be 256x256 pixels, min 80x80.
        /// </summary>
        [JsonProperty("chrome_web_default_notification_icon")]
        public string ChromeWebDefaultNotificationIcon { get; set; }

        /// <summary>
        /// Chrome (All Browsers except Safari): A subdomain of your choice in order to support Web Push on non-HTTPS websites. This field must be set in order for the chrome_web_gcm_sender_id property to be processed.
        /// </summary>
        [JsonProperty("chrome_web_sub_domain")]
        public string ChromeWebSubDomain { get; set; }

        /// <summary>
        /// All Browsers (Recommended): The Site Name. Requires both chrome_web_origin and safari_site_origin to be set to add or update it.
        /// </summary>
        [JsonProperty("site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// Safari (Recommended): The hostname to your website including http(s)://
        /// </summary>
        [JsonProperty("safari_site_origin")]
        public string SafariSiteOrigin { get; set; }

        /// <summary>
        /// Safari: Your apple push notification p12 certificate files for Safari Push Notifications converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("safari_apns_certificates")]
        public string SafariApnsCertificates { get; set; }

        /// <summary>
        /// The certificate bundle ID for Safari Web Push
        /// </summary>
        [JsonProperty("safari_push_id")]
        public string SafariPushId { get; set; }

        /// <summary>
        /// Safari: A url for a 256x256 png notification icon.
        /// </summary>
        [JsonProperty("safari_icon_256_256")]
        public string SafariIcon256x256 { get; set; }

        /// <summary>
        /// Safari: A url for a 128x128 png notification icon.
        /// </summary>
        [JsonProperty("safari_icon_128_128")]
        public string SafariIcon128x128 { get; set; }

        /// <summary>
        /// Safari: A url for a 64x64 png notification icon.
        /// </summary>
        [JsonProperty("safari_icon_64_64")]
        public string SafariIcon64x64 { get; set; }

        /// <summary>
        /// Safari: A url for a 32x32 png notification icon.
        /// </summary>
        [JsonProperty("safari_icon_32_32")]
        public string SafariIcon32x32 { get; set; }

        /// <summary>
        /// Safari: A url for a 16x16 png notification icon.
        /// </summary>
        [JsonProperty("safari_icon_16_16")]
        public string SafariIcon16x16 { get; set; }

        /// <summary>
        /// The auth key to access this newly created app.
        /// </summary>
        [JsonProperty("basic_auth_key")]
        public string BasicAuthKey { get; set; }
    }
}
