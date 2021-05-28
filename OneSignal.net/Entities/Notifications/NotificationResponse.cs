using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace OneSignal {
    public class NotificationResponse {
        /// <summary>
        /// <para>Amazon</para>
        /// <para>Picture to display in the expanded view. Can be a drawable resource name or a URL.</para>
        /// </summary>
        [JsonProperty("adm_big_picture")]
        public string AmazonBigPicture { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// <para>Notifications with the same group will be stacked together using Android's <a href="https://documentation.onesignal.com/docs/android-customizations#section-notification-grouping">Notification Grouping</a> feature.</para>
        /// </summary>
        [JsonProperty("adm_group")]
        public string AmazonGroup { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// <para>Summary message to display when 2+ notifications are stacked together. Default is "# new messages". Include $[notif_count] in your message and it will be replaced with the current number. "en" (English) is required. The key of each hash is either a a 2 character language code or one of zh-Hans/zh-Hant for Simplified or Traditional Chinese. The value of each key is the message that will be sent to users for that language.</para>
        /// <para>Example: {"en": "You have $[notif_count] new messages"}</para>
        /// </summary>
        [JsonProperty("adm_group_message")]
        public Dictionary<string, string> AmazonGroupMessage { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// <para>If blank the small_icon is used. Can be a drawable resource name or a URL.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a></para>
        /// </summary>
        [JsonProperty("adm_large_icon")]
        public string AmazonLargeIcon { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// If not set a bell icon will be used or ic_stat_onesignal_default if you have set this resource name.
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a></para>
        /// </summary>
        [JsonProperty("adm_small_icon")]
        public string AmazonSmallIcon { get; set; }

        [JsonProperty("spoken_text")]
        public Dictionary<string, string> SpokenText { get; set; }

        [JsonProperty("alexa_ssml")]
        public string AlexaSsml { get; set; }

        [JsonProperty("alex_display_title")]
        public string AlexaDisplayTitle { get; set; }

        [JsonProperty("amazon_background_data")]
        public bool? AmazonBackgroundData { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Sets the background color of the notification circle to the left of the notification text. Only applies to apps targeting Android API level 21+ on Android 5.0+ devices.</para>
        /// <para>Example(Red) : "FFFF0000"</para>
        /// </summary>
        [JsonProperty("android_accent_color")]
        public string AndroidAccentColor { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Notifications with the same group will be stacked together using Android's <a href="https://documentation.onesignal.com/docs/android-customizations#section-notification-grouping">Notification Grouping</a> feature.</para>
        /// </summary>
        [JsonProperty("android_group")]
        public string AndroidGroup { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Note: This only works for Android 6 and older. Android 7+ allows full expansion of all message.</para>
        /// <para>Summary message to display when 2+ notifications are stacked together.Default is "# new messages". Include $[notif_count] in your message and it will be replaced with the current number.</para>
        /// <para>Languages - The value of each key is the message that will be sent to users for that language. "en" (English) is required.The key of each hash is either a a 2 character language code or one of zh-Hans/zh-Hant for Simplified or Traditional Chinese. Read more: supported languages.</para>
        /// <para>Example: { "en": "You have $[notif_count] new messages"}</para>
        /// </summary>
        [JsonProperty("android_group_message")]
        public Dictionary<string, string> AndroidGroupMessage { get; set; }

        /// <summary>
        /// Your app id
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Picture to display in the expanded view. Can be a drawable resource name or a URL.</para>
        /// </summary>
        [JsonProperty("big_picture")]
        public string BigPicture { get; set; }

        /// <summary>
        /// <para>iOS 8.0+, Android 4.1+, and derivatives like Amazon</para>
        /// <para>Buttons to add to the notification. Icon only works for Android.</para>
        /// <para>Buttons show in reverse order of array position i.e.Last item in array shows as first button on device.</para>
        /// <para>Example: [{ "id": "id2", "text": "second button", "icon": "ic_menu_share"}, {"id": "id1", "text": "first button", "icon": "ic_menu_send"}]</para>
        /// </summary>
        [JsonProperty("buttons")]
        public List<Dictionary<string, string>> Buttons { get; set; }

        /// <summary>
        /// If the notification was canceled
        /// </summary>
        [JsonProperty("canceled")]
        public bool Canceled { get; set; }

        /// <summary>
        /// <para>ChromeApp</para>
        /// <para>Large picture to display below the notification text. Must be a local URL.</para>
        /// </summary>
        [JsonProperty("chrome_big_picture")]
        public string ChromeBigPicture { get; set; }

        /// <summary>
        /// <para>Chrome</para>
        /// <para>This flag is not used for web push For web push, please see chrome_web_icon instead.</para>
        /// <para>The local URL to an icon to use.If blank, the app icon will be used.</para>
        /// </summary>
        [JsonProperty("chrome_icon")]
        public string ChromeIcon { get; set; }

        /// <summary>
        /// <para>Chrome</para>
        /// <para>Sets the web push notification's icon. An image URL linking to a valid image.</para>
        /// <para>Common image types are supported; GIF will not animate. We recommend 256x256 (at least 80x80) to display well on high DPI devices.</para>
        /// <para>Firefox will also use this icon, unless you specify firefox_icon.</para>
        /// </summary>
        [JsonProperty("chrome_web_icon")]
        public string ChromeWebIcon { get; set; }

        /// <summary>
        /// <para>Chrome 56+</para>
        /// <para>Sets the web push notification's large image to be shown below the notification's title and text. Please see <a href="https://documentation.onesignal.com/docs/web-push-notification-icons">Web Push Notification Icons</a>.</para>
        /// </summary>
        [JsonProperty("chrome_web_image")]
        public string ChromeWebImage { get; set; }

        /// <summary>
        /// <para>Chrome</para>
        /// <para>Sets the web push notification icon for Android devices in the notification shade. Please see <a href="https://documentation.onesignal.com/docs/web-push-notification-icons#section-badge">Web Push Notification Badge</a>.</para>
        /// </summary>
        [JsonProperty("chrome_web_badge")]
        public string ChromeWebBadge { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>Sending true wakes your app from background to run custom native code (Apple interprets this as content-available=1).</para>
        /// <para>Note: Not applicable if the app is in the "force-quit" state (i.e app was swiped away). Omit the contents field to prevent displaying a visible notification</para>
        /// </summary>
        [JsonProperty("content_available")]
        public bool? ContentAvailable { get; set; }

        /// <summary>
        /// <para>Required unless ContentAvailable=true or TemplateId is set.</para>
        /// <para>The notification's content (excluding the title), a map of language codes to text for each language.</para>
        /// <para>Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.</para>
        /// <para>This field supports inline substitutions.</para>
        /// <para>English must be included in the hash.</para>
        /// <para>Example: { "en": "English Message", "es": "Spanish Message"}</para>
        /// </summary>
        [JsonProperty("contents")]
        public Dictionary<string, string> Contents { get; set; }

        [JsonProperty("converted")]
        public int Converted { get; set; }

        /// <summary>
        /// <para>A custom map of data that is passed back to your app. Same as using Additional Data within the dashboard. Can use up to 2048 bytes of data.</para>
        /// <para>Example: {"abc": 123, "foo": "bar", "event_performed": true, "amount": 12.1}</para>
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// <para>Possible values are:</para>
        /// <para>timezone(Deliver at a specific time-of-day in each users own timezone)</para>
        /// <para>last-active Same as Intelligent Delivery. (Deliver at the same time of day as each user last used your app).</para>
        /// <para>If send_after is used, this takes effect after the send_after time has elapsed.</para>
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("delayed_option")]
        public DelayedOption? DelayedOption { get; set; }

        /// <summary>
        /// <para>Use with delayed_option=timezone.</para>
        /// <para>Examples: "9:00AM"</para>
        /// <para>"21:45"</para>
        /// <para>"9:45:30"</para>
        /// </summary>
        [JsonProperty("delivery_time_of_day")]
        public string DeliveryTimeOfDay { get; set; }

        /// <summary>
        /// If the notification had an error sending
        /// </summary>
        [JsonProperty("errored")]
        public int Errored { get; set; }

        /// <summary>
        /// If the notification failed to send
        /// </summary>
        [JsonProperty("failed")]
        public int Failed { get; set; }

        /// <summary>
        /// <para>Firefox</para>
        /// <para>Not recommended Few people need to set Firefox-specific icons. We recommend setting chrome_web_icon instead, which Firefox will also use.</para>
        /// <para>Sets the web push notification's icon for Firefox. An image URL linking to a valid image. Common image types are supported; GIF will not animate. We recommend 256x256 (at least 80x80) to display well on high DPI devices.</para>
        /// </summary>
        [JsonProperty("firefox_icon")]
        public string FirefoxIcon { get; set; }

        [JsonProperty("global_image")]
        public string GlobalImage { get; set; }

        /// <summary>
        /// <para>The notification's title, a map of language codes to text for each language. Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.</para>
        /// <para>This field supports inline substitutions.</para>
        /// <para>Example: {"en": "English Title", "es": "Spanish Title"}</para>
        /// </summary>
        [JsonProperty("headings")]
        public Dictionary<string, string> Headings { get; set; }

        /// <summary>
        /// The notification id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specific playerids to send your notification to. Does not require API Auth Key.</para>
        /// <para>Do not combine with other targeting parameters. Not compatible with any other targeting parameters.</para>
        /// <para>Example: ["1dd608f2-c6a1-11e3-851d-000c2940e62c"]</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_player_ids")]
        public List<string> IncludePlayerIds { get; set; }

        /// <summary>
        /// <para>Target specific devices by custom user IDs assigned via API.</para>
        /// <para>Not compatible with any other targeting parameters</para>
        /// <para>Example: [“custom-id-assigned-by-api”]</para>
        /// <para>REQUIRED: REST API Key Authentication</para>
        /// <para>Limit of 2,000 entries per REST API call.</para>
        /// <para>Note: If targeting push and email subscribers with same ids, use with ChannelForExternalIds to indicate you are sending a push or email.</para>
        /// </summary>
        [JsonProperty("include_external_user_ids")]
        public List<string> IncludeExternalUserIds { get; set; }

        /// <summary>
        /// <para>The segment names you want to target. Users in these segments will receive a notification. This targeting parameter is only compatible with excluded_segments.</para>
        /// <para>Example: ["Active Users", "Inactive Users"]</para>
        /// </summary>
        [JsonProperty("included_segments")]
        public List<string> IncludedSegments { get; set; }

        /// <summary>
        /// <para>iOS 12+</para>
        /// <para>This parameter is supported in iOS 12 and above. It allows you to group related notifications together.</para>
        /// <para>If two notifications have the same thread-id, they will both be added to the same group.</para>
        /// </summary>
        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>Used with ios_badgeType, describes the value to set or amount to increase/decrease your app's iOS badge count by.</para>
        /// <para>You can use a negative number to decrease the badge count when used with an ios_badgeType of Increase.</para>
        /// </summary>
        [JsonProperty("ios_badgeCount")]
        public int? IosBadgeCount { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>Describes whether to set or increase/decrease your app's iOS badge count by the ios_badgeCount specified count. Can specify None, SetTo, or Increase.</para>
        /// <para>None leaves the count unaffected.</para>
        /// <para>SetTo directly sets the badge count to the number specified in ios_badgeCount.</para>
        /// <para>Increase adds the number specified in ios_badgeCount to the total.Use a negative number to decrease the badge count.</para>
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("ios_badgeType")]
        public IosBadgeType? IosBadgeType { get; set; }

        /// <summary>
        /// <para><a href="https://developer.apple.com/documentation/usernotifications/unnotificationcategory">Category APS</a> payload, use with registerUserNotificationSettings:categories in your Objective-C / Swift code.</para>
        /// <para>Example: calendar category which contains actions like accept and decline</para>
        /// <para>iOS 10+ This will trigger your UNNotificationContentExtension whose ID matches this category.</para>
        /// </summary>
        [JsonProperty("ios_category")]
        public string IosCategory { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>Sound file that is included in your app to play instead of the default device notification sound. Pass nil to disable vibration and sound for the notification.</para>
        /// <para>Example: "notification.wav"</para>
        /// </summary>
        [JsonProperty("ios_sound")]
        public string IosSound { get; set; }

        /// <summary>
        /// <para>iOS 10+</para>
        /// <para>iOS can localize push notification messages on the client using special parameters such as loc-key. When using the Create Notification endpoint, you must include these parameters inside of a field called apns_alert. Please see <a href="https://developer.apple.com/library/archive/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/CreatingtheNotificationPayload.html#//apple_ref/doc/uid/TP40008194-CH10-SW1">Apple's guide</a> on localizing push notifications to learn more.</para>
        /// </summary>
        [JsonProperty("apns_alert")]
        public Dictionary<string, string> ApnsAlert { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Amazon Fire platform.
        /// </summary>
        [JsonProperty("isAdm")]
        public bool IsAdm { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Google Android platform.
        /// </summary>
        [JsonProperty("isAndroid")]
        public bool IsAndroid { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Chrome platform.
        /// </summary>
        [JsonProperty("isChrome")]
        public bool IsChrome { get; set; }

        /// <summary>
        /// Indicates whether to send to all Google Chrome, Chrome on Android, and Mozilla Firefox users registered under your Chrome & Firefox web push platform.
        /// </summary>
        [JsonProperty("isChromeWeb")]
        public bool IsChromeWeb { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Alexa platform.
        /// </summary>
        [JsonProperty("isAlexa")]
        public bool IsAlexa { get; set; }

        /// <summary>
        /// Indicates whether to send to all Mozilla Firefox desktop users registered under your Firefox web push platform.
        /// </summary>
        [JsonProperty("isFirefox")]
        public bool IsFirefox { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Apple iOS platform.
        /// </summary>
        [JsonProperty("isIos")]
        public bool IsIos { get; set; }

        [JsonProperty("isSafari")]
        public bool IsSafari { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Windows platform.
        /// </summary>
        [JsonProperty("isWP")]
        public bool IsWP { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Windows platform.
        /// </summary>
        [JsonProperty("isWP_WNS")]
        public bool IsWpWns { get; set; }

        /// <summary>
        /// Indicates whether to send to all Mozilla Firefox desktop users registered under your Edge web push platform.
        /// </summary>
        [JsonProperty("isEdge")]
        public bool IsEdge { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Can be a drawable resource name or a URL.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-large-notification-icons">How to create large icons</a></para>
        /// </summary>
        [JsonProperty("large_icon")]
        public string LargeIcon { get; set; }

        /// <summary>
        /// <para>Android, Chrome, ChromeWeb</para>
        /// <para>Delivery priority through the push server (example GCM/FCM). Pass 10 for high priority or any other integer for normal priority. Defaults to normal priority for Android and high for iOS. For Android 6.0+ devices setting priority to high will wake the device out of doze mode.</para>
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The time the notification was queued
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("queued_at")]
        public DateTime QueuedAt { get; set; }

        /// <summary>
        /// Remaining players that still haven't received the notification
        /// </summary>
        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        /// <summary>
        /// <para>Schedule notification for future delivery. API defaults to UTC -1100</para>
        /// <para>Examples: All examples are the exact same date & time.</para>
        /// <para>"Thu Sep 24 2015 14:00:00 GMT-0700 (PDT)"</para>
        /// <para>"September 24th 2015, 2:00:00 pm UTC-07:00"</para>
        /// <para>"2015-09-24 14:00:00 GMT-0700"</para>
        /// <para>"Sept 24 2015 14:00:00 GMT-0700"</para>
        /// <para>"Thu Sep 24 2015 14:00:00 GMT-0700 (Pacific Daylight Time)"</para>
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("send_after")]
        public DateTime SendAfter { get; set; }

        /// <summary>
        /// When the notification completed sending to all players
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("completed_at")]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Icon shown in the status bar and on the top left of the notification.</para>
        /// <para>If not set a bell icon will be used or ic_stat_onesignal_default if you have set this resource name.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a></para>
        /// </summary>
        [JsonProperty("small_icon")]
        public string SmallIcon { get; set; }

        /// <summary>
        /// Indicates if the notification successfully sent
        /// </summary>
        [JsonProperty("successful")]
        public int Successful { get; set; }

        /// <summary>
        /// How many players received the notification
        /// </summary>
        [JsonProperty("received")]
        public int? Received { get; set; }

        /// <summary>
        /// All the tags associated to the notification
        /// </summary>
        [JsonProperty("tags")]
        public List<string> tags { get; set; }

        /// <summary>
        /// <para>The filters parameter targets notification recipients using an array of JSON objects containing field conditions to check. The following are filter options:</para>
        /// </summary>
        [JsonProperty("filters")]
        public List<Dictionary<string, string>> Filters { get; set; }

        /// <summary>
        /// <para>iOS 10+</para>
        /// <para>Use a template you setup on our dashboard. The template_id is the UUID found in the URL when viewing a template on our dashboard.</para>
        /// <para>Example: be4a8044-bbd6-11e4-a581-000c2940e62c</para>
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>iOS, Android, Chrome, Firefox, Safari, ChromeWeb	</para>
        /// <para>Time To Live - In seconds. The notification will be expired if the device does not come back online within this time. The default is 259,200 seconds (3 days).</para>
        /// <para>Max value to set is 2419200 seconds(28 days).</para>
        /// </summary>
        [JsonProperty("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The URL to open in the browser when a user clicks on the notification.</para>
        /// <para>Example: https://onesignal.com</para>
        /// <para>Note: iOS needs https or updated NSAppTransportSecurity in plist</para>
        /// <para>This field supports inline substitutions.</para>
        /// <para>Omit if including web_url or app_url</para>
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// <para>Push - All Browsers</para>
        /// <para>Same as url but only sent to web push platforms.</para>
        /// <para>Including Chrome, Firefox, Safari, Opera, etc.</para>
        /// </summary>
        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        /// <summary>
        /// <para>Push - Mobile Apps</para>
        /// <para>Same as url but only sent to app platforms.</para>
        /// <para>Including iOS, Android, macOS, Windows, ChromeApps, etc.</para>
        /// </summary>
        [JsonProperty("app_url")]
        public string AppUrl { get; set; }

        /// <summary>
        /// <para>Chrome 48+</para>
        /// <para>Add action buttons to the notification. The id field is required.</para>
        /// <para>Example: [{"id": "like-button", "text": "Like", "icon": "http://i.imgur.com/N8SN8ZS.png", "url": "https://yoursite.com"}, {"id": "read-more-button", "text": "Read more", "icon": "http://i.imgur.com/MIxJp1L.png", "url": "https://yoursite.com"}]</para>
        /// </summary>
        [JsonProperty("web_buttons")]
        public List<Dictionary<string, string>> WebButtons { get; set; }

        /// <summary>
        /// The web topic the notification was sent under
        /// </summary>
        [JsonProperty("web_push_topic")]
        public string WebPushTopic { get; set; }

        /// <summary>
        /// <para>Windows</para>
        /// <para>Sound file that is included in your app to play instead of the default device notification sound.</para>
        /// <para>Example: "notification.wav"</para>
        /// </summary>
        [JsonProperty("wp_sound")]
        public string WpSound { get; set; }

        /// <summary>
        /// <para>Windows</para>
        /// <para>Sound file that is included in your app to play instead of the default device notification sound.</para>
        /// <para>Example: "notification.wav"</para>
        /// </summary>
        [JsonProperty("wp_wns_sound")]
        public string WpWnsSound { get; set; }

        /// <summary>
        /// The delivery stats per platform
        /// </summary>
        [JsonProperty("platform_delivery_stats")]
        public PlatformDeliveryStats PlatformDeliveryStats { get; set; }

        /// <summary>
        /// <para>iOS 10+</para>
        /// <para>Adds media attachments to notifications. Set as JSON object, key as a media id of your choice and the value as a valid local filename or URL. User must press and hold on the notification to view.</para>
        /// <para>Do not set mutable_content to download attachments.The OneSignal SDK does this automatically</para>
        /// <para>Example: {"id1": "https://domain.com/image.jpg"}</para>
        /// </summary>
        [JsonProperty("ios_attachments")]
        public Dictionary<string, string> IosAttachments { get; set; }

        /// <summary>
        /// The outcome aggregations for each possible outcome
        /// </summary>
        [JsonProperty("outcomes")]
        public List<NotificationOutcome> Outcomes { get; set; }
    }
}
