using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OneSignal {
    public class CreateUpdateAppOptions : BaseOptions {
        /// <summary>
        /// Required: The name of your new app, as displayed on your apps list on the dashboard. This can be renamed later.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// iOS: Either sandbox or production
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("apns_env")]
        public ApnsEnvironment? ApnsEnvironment { get; set; }

        /// <summary>
        /// iOS: Your apple push notification p12 certificate file, converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("apns_p12")]
        public string ApnsP12 { get; set; }

        /// <summary>
        /// iOS Required if adding p12 certificate - Password for the apns_p12 file
        /// </summary>
        [JsonProperty("apns_p12_password")]
        public string ApnsP12Password { get; set; }

        /// <summary>
        /// Android: Your Google Push Messaging Auth Key
        /// </summary>
        [JsonProperty("gcm_key")]
        public string GcmKey { get; set; }

        /// <summary>
        /// Android: Your Google Project number. Also know as Sender ID.
        /// </summary>
        [JsonProperty("android_gcm_sender_id")]
        public string AndroidGcmSenderId { get; set; }

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
        /// Safari: Your apple push notification p12 certificate file for Safari Push Notifications, converted to a string and Base64 encoded.
        /// </summary>
        [JsonProperty("safari_apns_p12")]
        public string SafariApnsP12 { get; set; }

        /// <summary>
        /// Safari: Password for safari_apns_p12 file
        /// </summary>
        [JsonProperty("safari_apns_p12_password")]
        public string SafariApnsP12Password { get; set; }

        /// <summary>
        /// Safari: A url for a 256x256 png notification icon. This is the only Safari icon URL you need to provide.
        /// </summary>
        [JsonProperty("safari_icon_256_256")]
        public string SafariIcon256x256 { get; set; }

        /// <summary>
        /// Not for web push. Your Google Push Messaging Auth Key if you use Chrome Apps / Extensions.
        /// </summary>
        [JsonProperty("chrome_key")]
        public string ChromeKey { get; set; }

        /// <summary>
        /// <para>iOS: Notification data (additional data) values will be added to the root of the apns payload when sent to the device.</para>
        /// <para>Ignore if you're not using any other plugins or not using OneSignal SDK methods to read the payload.</para>
        /// </summary>
        [JsonProperty("additional_data_is_root_payload")]
        public string AdditionalDataIsRootPayload { get; set; }

        /// <summary>
        /// The Id of the Organization you would like to add this app to.
        /// </summary>
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }
    }
}
