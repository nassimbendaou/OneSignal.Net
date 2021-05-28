using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace OneSignal {
    public class CreateNotificationOptions : BaseOptions {
        [JsonProperty("app_id")]
        public string AppId { get; private set; }

        #region Segments

        /// <summary>
        /// <para>The segment names you want to target. Users in these segments will receive a notification. This targeting parameter is only compatible with excluded_segments.</para>
        /// <para>Example: ["Active Users", "Inactive Users"]</para>
        /// </summary>
        [JsonProperty("included_segments")]
        public List<string> IncludedSegments { get; set; }

        /// <summary>
        /// <para>Segment that will be excluded when sending. Users in these segments will not receive a notification, even if they were included in included_segments. This targeting parameter is only compatible with included_segments.</para>
        /// <para>Example: ["Active Users", "Inactive Users"]</para>
        /// </summary>
        [JsonProperty("excluded_segments")]
        public List<string> ExcludedSegments { get; set; }

        #endregion

        #region Filters

        /// <summary>
        /// <para>The filters parameter targets notification recipients using an array of JSON objects containing field conditions to check. The following are filter options:</para>
        /// NotificationFilterAmountSpent - Amount in USD a user has spent on in app purchases<br />
        /// NotificationFilterAppVersion - Users that have the target app version<br />
        /// NotificationFilterBoughtSku - Amount a user has spent on a specific SKU as an in app purchase<br />
        /// NotificationFilterCountry - Users that are in a specific country<br />
        /// NotificationFilterEmail - Use this for targeting push subscribers associated with an email set with all SDK setEmail methods<br />
        /// NotificationFilterFirstSession - Number of hours before or after the users first session<br />
        /// NotificaitonFilterLanguage - Users with their device set to a specific language<br />
        /// NotificationFilterLastSession - Number of hours before or after the users last session<br />
        /// NotificationFilterLocation - Users within a specific distance from a latitude and longitude location<br />
        /// NotificationFilterOperator - Allows for specifying an OR operator between filters which are AND by default<br />
        /// NotificationFilterSessionCount - Number of session a user has<br />
        /// NotificationFilterTag - Filter users based on tags
        /// </summary>
        [JsonProperty("filters")]
        public List<NotificationFilter> Filters { get; set; }

        #endregion

        #region Specific Devices

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
        /// <para>Recommended for Sending Emails - Target specific email addresses.</para>
        /// <para>If an email does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: nick @catfac.ts</para>
        /// <para>>Limit of 2,000 entries per REST API call</para
        /// </summary>
        [JsonProperty("include_email_tokens")]
        public List<string> IncludeEmailTokens { get; set; }

        /// <summary>
        /// <para>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead.</para>
        /// <para>Target using iOS device tokens.</para>
        /// <para>Warning: Only works with Production tokens.</para>
        /// <para>All non-alphanumeric characters must be removed from each token. If a token does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: ce777617da7f548fe7a9ab6febb56cf39fba6d38203...</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_ios_tokens")]
        public List<string> IncludeIosTokens { get; set; }

        /// <summary>
        /// <para>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead.</para>
        /// <para>Target using Windows URIs.If a token does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: http://s.notify.live.net/u/1/bn1/HmQAAACPaLDr-...</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_wp_wns_uris")]
        public List<string> IncludeWpWnsUris { get; set; }

        /// <summary>
        /// <para>>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead.</para
        /// <para>Target using Amazon ADM registration IDs.If a token does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: amzn1.adm-registration.v1.XpvSSUk0Rc3hTVVV...</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_amazon_reg_ids")]
        public List<string> IncludeAmazonRegistrationIds { get; set; }

        /// <summary>
        /// <para>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead.</para>
        /// <para>Target using Chrome App registration IDs.If a token does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_...</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_chrome_reg_ids")]
        public List<string> IncludeChromeRegistrationIds { get; set; }

        /// <summary>
        /// <para>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead.</para>
        /// <para>Target using Chrome Web Push registration IDs.If a token does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_...</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_chrome_web_reg_ids")]
        public List<string> IncludeChromeWebRegistrationIds { get; set; }

        /// <summary>
        /// <para>Not Recommended: Please consider using include_player_ids or include_external_user_ids instead.</para>
        /// <para>Target using Android device registration IDs.If a token does not correspond to an existing user, a new user will be created.</para>
        /// <para>Example: APA91bEeiUeSukAAUdnw3O2RB45FWlSpgJ7Ji_...</para>
        /// <para>Limit of 2,000 entries per REST API call</para>
        /// </summary>
        [JsonProperty("include_android_reg_ids")]
        public List<string> IncludeAndroidRegistrationIds { get; set; }

        #endregion

        #region Idempotency

        /// <summary>
        /// <para>Correlation and idempotency key.</para>
        /// <para>A request received with this parameter will first look for another notification with the same external_id.If one exists, a notification will not be sent, and result of the previous operation will instead be returned. Therefore, if you plan on using this feature, it's important to use a good source of randomness to generate the UUID passed here.</para>
        /// <para>This key is only idempotent for 30 days.After 30 days, the notification could be removed from our system and a notification with the same external_id will be sent again.</para>
        /// <para>See <a href="https://documentation.onesignal.com/docs/idempotent-notification-requests">Idempotent Notification Requests</a> for more details</para>
        /// </summary>
        [JsonProperty("external_id")]
        public string IdempotencyId { get; set; }

        #endregion

        #region Notification Content

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

        /// <summary>
        /// <para>The notification's title, a map of language codes to text for each language. Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.</para>
        /// <para>This field supports inline substitutions.</para>
        /// <para>Example: {"en": "English Title", "es": "Spanish Title"}</para>
        /// </summary>
        [JsonProperty("headings")]
        public Dictionary<string, string> Headings { get; set; }

        /// <summary>
        /// <para>The notification's subtitle, a map of language codes to text for each language. Each hash must have a language code string for a key, mapped to the localized text you would like users to receive for that language.</para>
        /// <para>This field supports inline substitutions.</para>
        /// <para>Example: {"en": "English Subtitle", "es": "Spanish Subtitle"}</para>
        /// </summary>
        [JsonProperty("subtitle")]
        public Dictionary<string, string> Subtitle { get; set; }

        /// <summary>
        /// <para>iOS 10+</para>
        /// <para>Use a template you setup on our dashboard. The template_id is the UUID found in the URL when viewing a template on our dashboard.</para>
        /// <para>Example: be4a8044-bbd6-11e4-a581-000c2940e62c</para>
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>Sending true wakes your app from background to run custom native code (Apple interprets this as content-available=1).</para>
        /// <para>Note: Not applicable if the app is in the "force-quit" state (i.e app was swiped away). Omit the contents field to prevent displaying a visible notification</para>
        /// </summary>
        [JsonProperty("content_available")]
        public bool? ContentAvailable { get; set; }

        /// <summary>
        /// <para>iOS 10+</para>
        /// <para>Always defaults to true and cannot be turned off.</para>
        /// <para>Allows tracking of notification receives and changing of the notification content in your app before it is displayed.</para>
        /// <para>Triggers didReceive(_:withContentHandler:) on your UNNotificationServiceExtension</para>
        /// </summary>
        [JsonProperty("mutable_content")]
        public bool? MutableContent { get; set; }

        /// <summary>
        /// <para>Use to target a specific experience in your <a href="https://documentation.onesignal.com/docs/app-clip-support">App Clip</a>, or to target your notification to a specific window in a multi-scene App.</para>
        /// </summary>
        [JsonProperty("target_content_identifier")]
        public string TargetContentIdentifier { get; set; }

        #endregion

        #region Email Content

        /// <summary>
        /// <para>Required: The subject of the email.</para>
        /// </summary>
        [JsonProperty("email_subject")]
        public string EmailSubject { get; set; }

        /// <summary>
        /// <para>Required unless template_id is set.</para>
        /// <para>The body of the email you wish to send.Typically, customers include their own HTML templates here.Must include[unsubscribe_url] in an<a> tag somewhere in the email.</para>
        /// <para>Note: any malformed HTML content will be sent to users.Please double-check your HTML is valid.</para>
        /// </summary>
        [JsonProperty("email_body")]
        public string EmailBody { get; set; }

        /// <summary>
        /// <para>The name the email is from. If not specified, will default to "from name" set in the OneSignal Dashboard Email Settings.</para>
        /// </summary>
        [JsonProperty("email_from_name")]
        public string EmailFromName { get; set; }

        /// <summary>
        /// <para>The email address the email is from. If not specified, will default to "from email" set in the OneSignal Dashboard Email Settings.</para>
        /// </summary>
        [JsonProperty("email_from_address")]
        public string EmailFromAddress { get; set; }

        #endregion

        #region Attachments (Push Only)

        /// <summary>
        /// <para>A custom map of data that is passed back to your app. Same as using Additional Data within the dashboard. Can use up to 2048 bytes of data.</para>
        /// <para>Example: {"abc": 123, "foo": "bar", "event_performed": true, "amount": 12.1}</para>
        /// </summary>
        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>Use "data" or "message" depending on the type of notification you are sending. More details in <a href="https://documentation.onesignal.com/docs/data-notifications">Data & Background Notifications</a>.</para>
        /// </summary>
        [JsonProperty("hauwei_msg_type")]
        public string HuaweiMessageType { get; set; }

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
        /// <para>iOS 10+</para>
        /// <para>Adds media attachments to notifications. Set as JSON object, key as a media id of your choice and the value as a valid local filename or URL. User must press and hold on the notification to view.</para>
        /// <para>Do not set mutable_content to download attachments.The OneSignal SDK does this automatically</para>
        /// <para>Example: {"id1": "https://domain.com/image.jpg"}</para>
        /// </summary>
        [JsonProperty("ios_attachments")]
        public Dictionary<string, string> IosAttachments { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Picture to display in the expanded view. Can be a drawable resource name or a URL.</para>
        /// </summary>
        [JsonProperty("big_picture")]
        public string BigPicture { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>Picture to display in the expanded view. Can be a drawable resource name or a URL.</para>
        /// </summary>
        [JsonProperty("huawei_big_picture")]
        public string HuaweiBigPicture { get; set; }

        /// <summary>
        /// <para>Chrome 56+</para>
        /// <para>Sets the web push notification's large image to be shown below the notification's title and text. Please see <a href="https://documentation.onesignal.com/docs/web-push-notification-icons">Web Push Notification Icons</a>.</para>
        /// </summary>
        [JsonProperty("chrome_web_image")]
        public string ChromeWebImage { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// <para>Picture to display in the expanded view. Can be a drawable resource name or a URL.</para>
        /// </summary>
        [JsonProperty("adm_big_picture")]
        public string AmazonBigPicture { get; set; }

        /// <summary>
        /// <para>ChromeApp</para>
        /// <para>Large picture to display below the notification text. Must be a local URL.</para>
        /// </summary>
        [JsonProperty("chrome_big_picture")]
        public string ChromeBigPicture { get; set; }

        #endregion

        #region Action Buttons

        /// <summary>
        /// <para>iOS 8.0+, Android 4.1+, and derivatives like Amazon</para>
        /// <para>Buttons to add to the notification. Icon only works for Android.</para>
        /// <para>Buttons show in reverse order of array position i.e.Last item in array shows as first button on device.</para>
        /// <para>Example: [{ "id": "id2", "text": "second button", "icon": "ic_menu_share"}, {"id": "id1", "text": "first button", "icon": "ic_menu_send"}]</para>
        /// </summary>
        [JsonProperty("buttons")]
        public List<Dictionary<string, string>> Buttons { get; set; }

        /// <summary>
        /// <para>Chrome 48+</para>
        /// <para>Add action buttons to the notification. The id field is required.</para>
        /// <para>Example: [{"id": "like-button", "text": "Like", "icon": "http://i.imgur.com/N8SN8ZS.png", "url": "https://yoursite.com"}, {"id": "read-more-button", "text": "Read more", "icon": "http://i.imgur.com/MIxJp1L.png", "url": "https://yoursite.com"}]</para>
        /// </summary>
        [JsonProperty("web_buttons")]
        public List<Dictionary<string, string>> WebButtons { get; set; }

        /// <summary>
        /// <para><a href="https://developer.apple.com/documentation/usernotifications/unnotificationcategory">Category APS</a> payload, use with registerUserNotificationSettings:categories in your Objective-C / Swift code.</para>
        /// <para>Example: calendar category which contains actions like accept and decline</para>
        /// <para>iOS 10+ This will trigger your UNNotificationContentExtension whose ID matches this category.</para>
        /// </summary>
        [JsonProperty("ios_category")]
        public string IosCategory { get; set; }

        #endregion

        #region Appearance

        /// <summary>
        /// <para>Android</para>
        /// <para>The Android Oreo Notification Category to send the notification under. See the <a href="https://documentation.onesignal.com/docs/android-notification-categories">Category documentation</a> on creating one and getting it's id.</para>
        /// </summary>
        [JsonProperty("android_channel_id")]
        public string AndroidChannelId { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>The Android Oreo Notification Category to send the notification under. See the <a href="https://documentation.onesignal.com/docs/android-notification-categories">Category documentation</a> on creating one and getting it's id.</para>
        /// </summary>
        [JsonProperty("huawei_channel_id")]
        public string HuaweiChannelId { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Use this if you have client side Android Oreo Channels you have already defined in your app with code.</para>
        /// </summary>
        [JsonProperty("existing_android_channel_id")]
        public string ExistingAndroidChannelId { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>Use this if you have client side Android Oreo Channels you have already defined in your app with code.</para>
        /// </summary>
        [JsonProperty("huawei_existing_channel_id")]
        public string HuaweiExistingChannelId { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Allowing setting a background image for the notification. This is a JSON object containing the following keys. See our <a href="https://documentation.onesignal.com/docs/android-customizations#section-background-images">Background Image</a> documentation for image sizes.</para>
        /// <para>Example: {"image": "https://domain.com/background_image.jpg", "headings_color": "FFFF0000", "contents_color": "FF00FF00"}</para>
        /// </summary>
        [JsonProperty("android_background_layout")]
        public AndroidBackgroundLayout AndroidBackgroundLayout { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Icon shown in the status bar and on the top left of the notification.</para>
        /// <para>If not set a bell icon will be used or ic_stat_onesignal_default if you have set this resource name.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a></para>
        /// </summary>
        [JsonProperty("small_icon")]
        public string SmallIcon { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>Icon shown in the status bar and on the top left of the notification.</para>
        /// <para>Use an Android resource path(E.g. /drawable/small_icon).</para>
        /// <para>Defaults to your app icon if not set.</para>
        /// </summary>
        [JsonProperty("huawei_small_icon")]
        public string HuaweiSmallIcon { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Can be a drawable resource name or a URL.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-large-notification-icons">How to create large icons</a></para>
        /// </summary>
        [JsonProperty("large_icon")]
        public string LargeIcon { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>Can be a drawable resource name or a URL.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-large-notification-icons">How to create large icons</a></para>
        /// </summary>
        [JsonProperty("huawei_large_icon")]
        public string HuaweiLargeIcon { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// If not set a bell icon will be used or ic_stat_onesignal_default if you have set this resource name.
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a></para>
        /// </summary>
        [JsonProperty("adm_small_icon")]
        public string AmazonSmallIcon { get; set; }

        /// <summary>
        /// <para>Amazon</para>
        /// <para>If blank the small_icon is used. Can be a drawable resource name or a URL.</para>
        /// <para>See: <a href="https://documentation.onesignal.com/docs/android-customizations#section-small-notification-icons">How to create small icons</a></para>
        /// </summary>
        [JsonProperty("adm_large_icon")]
        public string AmazonLargeIcon { get; set; }

        /// <summary>
        /// <para>Chrome</para>
        /// <para>Sets the web push notification's icon. An image URL linking to a valid image.</para>
        /// <para>Common image types are supported; GIF will not animate. We recommend 256x256 (at least 80x80) to display well on high DPI devices.</para>
        /// <para>Firefox will also use this icon, unless you specify firefox_icon.</para>
        /// </summary>
        [JsonProperty("chrome_web_icon")]
        public string ChromeWebIcon { get; set; }

        /// <summary>
        /// <para>Chrome</para>
        /// <para>Sets the web push notification icon for Android devices in the notification shade. Please see <a href="https://documentation.onesignal.com/docs/web-push-notification-icons#section-badge">Web Push Notification Badge</a>.</para>
        /// </summary>
        [JsonProperty("chrome_web_badge")]
        public string ChromeWebBadge { get; set; }

        /// <summary>
        /// <para>Firefox</para>
        /// <para>Not recommended Few people need to set Firefox-specific icons. We recommend setting chrome_web_icon instead, which Firefox will also use.</para>
        /// <para>Sets the web push notification's icon for Firefox. An image URL linking to a valid image. Common image types are supported; GIF will not animate. We recommend 256x256 (at least 80x80) to display well on high DPI devices.</para>
        /// </summary>
        [JsonProperty("firefox_icon")]
        public string FirefoxIcon { get; set; }

        /// <summary>
        /// <para>Chrome</para>
        /// <para>This flag is not used for web push For web push, please see chrome_web_icon instead.</para>
        /// <para>The local URL to an icon to use.If blank, the app icon will be used.</para>
        /// </summary>
        [JsonProperty("chrome_icon")]
        public string ChromeIcon { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>Sound file that is included in your app to play instead of the default device notification sound. Pass nil to disable vibration and sound for the notification.</para>
        /// <para>Example: "notification.wav"</para>
        /// </summary>
        [JsonProperty("ios_sound")]
        public string IosSound { get; set; }

        /// <summary>
        /// <para>Windows</para>
        /// <para>Sound file that is included in your app to play instead of the default device notification sound.</para>
        /// <para>Example: "notification.wav"</para>
        /// </summary>
        [JsonProperty("wp_wns_sound")]
        public string WpWnsSound { get; set; }

        /// <summary>
        /// <para>Android</para>
        /// <para>Sets the background color of the notification circle to the left of the notification text. Only applies to apps targeting Android API level 21+ on Android 5.0+ devices.</para>
        /// <para>Example(Red) : "FFFF0000"</para>
        /// </summary>
        [JsonProperty("android_accent_color")]
        public string AndroidAccentColor { get; set; }

        /// <summary>
        /// <para>Huawei</para>
        /// <para>Accent Color used on Action Buttons and Group overflow count.</para>
        /// <para>Uses RGB Hex value(E.g. #9900FF).</para>
        /// <para>Defaults to device’s theme color if not set.</para>
        /// </summary>
        [JsonProperty("huawei_accent_color")]
        public string HuaweiAccentColor { get; set; }

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
        /// <para>iOS</para>
        /// <para>Used with ios_badgeType, describes the value to set or amount to increase/decrease your app's iOS badge count by.</para>
        /// <para>You can use a negative number to decrease the badge count when used with an ios_badgeType of Increase.</para>
        /// </summary>
        [JsonProperty("ios_badgeCount")]
        public int? IosBadgeCount { get; set; }

        /// <summary>
        /// <para>iOS 10+, Android</para>
        /// <para>Only one notification with the same id will be shown on the device. Use the same id to update an existing notification instead of showing a new one. Limit of 64 characters.</para>
        /// </summary>
        [JsonProperty("collapse_id")]
        public string CollapseId { get; set; }

        /// <summary>
        /// <para>iOS 10+</para>
        /// <para>iOS can localize push notification messages on the client using special parameters such as loc-key. When using the Create Notification endpoint, you must include these parameters inside of a field called apns_alert. Please see <a href="https://developer.apple.com/library/archive/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/CreatingtheNotificationPayload.html#//apple_ref/doc/uid/TP40008194-CH10-SW1">Apple's guide</a> on localizing push notifications to learn more.</para>
        /// </summary>
        [JsonProperty("apns_alert")]
        public Dictionary<string, string> ApnsAlert { get; set; }

        #endregion

        #region Delivery

        /// <summary>
        /// <para>Schedule notification for future delivery. API defaults to UTC -1100</para>
        /// <para>Examples: All examples are the exact same date & time.</para>
        /// <para>"Thu Sep 24 2015 14:00:00 GMT-0700 (PDT)"</para>
        /// <para>"September 24th 2015, 2:00:00 pm UTC-07:00"</para>
        /// <para>"2015-09-24 14:00:00 GMT-0700"</para>
        /// <para>"Sept 24 2015 14:00:00 GMT-0700"</para>
        /// <para>"Thu Sep 24 2015 14:00:00 GMT-0700 (Pacific Daylight Time)"</para>
        /// </summary>
        [JsonProperty("send_after")]
        public DateTime? SendAfter { get; set; }

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
        /// <para>iOS, Android, Chrome, Firefox, Safari, ChromeWeb	</para>
        /// <para>Time To Live - In seconds. The notification will be expired if the device does not come back online within this time. The default is 259,200 seconds (3 days).</para>
        /// <para>Max value to set is 2419200 seconds(28 days).</para>
        /// </summary>
        [JsonProperty("ttl")]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>Android, Chrome, ChromeWeb</para>
        /// <para>Delivery priority through the push server (example GCM/FCM). Pass 10 for high priority or any other integer for normal priority. Defaults to normal priority for Android and high for iOS. For Android 6.0+ devices setting priority to high will wake the device out of doze mode.</para>
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>iOS</para>
        /// <para>valid values: voip</para>
        /// <para>Set the value to voip for sending VoIP Notifications</para>
        /// <para>This field maps to the APNS header apns-push-type.</para>
        /// <para>Note: alert and background are automatically set by OneSignal</para>
        /// </summary>
        [JsonProperty("apns_push_type_override")]
        public string ApnsPushTypeOverride { get; set; }

        #endregion

        #region Group & Collapsing

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
        /// <para>iOS 12+</para>
        /// <para>This parameter is supported in iOS 12 and above. It allows you to group related notifications together.</para>
        /// <para>If two notifications have the same thread-id, they will both be added to the same group.</para>
        /// </summary>
        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        /// <summary>
        /// <para>iOS 12+</para>
        /// <para>When using thread_id to create grouped notifications in iOS 12+, you can also control the summary. For example, a grouped notification can say "12 more notifications from John Doe".</para>
        /// <para>The summary_arg lets you set the name of the person/thing the notifications are coming from, and will show up as "X more notifications from summary_arg"</para>
        /// </summary>
        [JsonProperty("summary_arg")]
        public string SummaryArg { get; set; }

        /// <summary>
        /// <para>iOS 12+</para>
        /// <para>When using thread_id, you can also control the count of the number of notifications in the group. For example, if the group already has 12 notifications, and you send a new notification with summary_arg_count = 2, the new total will be 14 and the summary will be "14 more notifications from summary_arg"</para>
        /// </summary>
        [JsonProperty("summary_arg_count")]
        public int? SummaryArgCount { get; set; }

        #endregion

        #region Platform Delivery

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Apple iOS platform.
        /// </summary>
        [JsonProperty("isIos")]
        public bool? IsIos { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Google Android platform.
        /// </summary>
        [JsonProperty("isAndroid")]
        public bool? IsAndroid { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Huawei Android platform.
        /// </summary>
        [JsonProperty("isHuawei")]
        public bool? IsHuawei { get; set; }

        /// <summary>
        /// <para>Indicates whether to send to all subscribed web browser users, including Chrome, Firefox, and Safari.</para>
        /// <para>You may use this instead as a combined flag instead of separately enabling isChromeWeb, isFirefox, and isSafari, though the three options are equivalent to this one.</para>
        /// </summary>
        [JsonProperty("isAnyWeb")]
        public bool? IsAnyWeb { get; set; }

        /// <summary>
        /// Indicates whether to send to all Google Chrome, Chrome on Android, and Mozilla Firefox users registered under your Chrome & Firefox web push platform.
        /// </summary>
        [JsonProperty("isChromeWeb")]
        public bool? IsChromeWeb { get; set; }

        /// <summary>
        /// Indicates whether to send to all Mozilla Firefox desktop users registered under your Firefox web push platform.
        /// </summary>
        [JsonProperty("isFirefox")]
        public bool? IsFirefox { get; set; }

        /// <summary>
        /// Does not support iOS Safari. Indicates whether to send to all Apple's Safari desktop users registered under your Safari web push platform. Read more: iOS Safari
        /// </summary>
        [JsonProperty("isSafari")]
        public bool? IsSafari { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Windows platform.
        /// </summary>
        [JsonProperty("isWP_WNS")]
        public bool? IsWpWns { get; set; }

        /// <summary>
        /// Indicates whether to send to all devices registered under your app's Amazon Fire platform.
        /// </summary>
        [JsonProperty("isAdm")]
        public bool? IsAdm { get; set; }

        /// <summary>
        /// <para>This flag is not used for web push Please see isChromeWeb for sending to web push users. This flag only applies to Google Chrome Apps & Extensions.</para>
        /// <para>Indicates whether to send to all devices registered under your app's Google Chrome Apps & Extension platform.</para>
        /// </summary>
        [JsonProperty("isChrome")]
        public bool? IsChrome { get; set; }

        /// <summary>
        /// <para>Indicates if the message type when targeting with include_external_user_ids for cases where an email and push subscriber has the same external user id.</para>
        /// <para>Example: Use the string "push" to indicate you are sending a push notification or the string "email"for sending emails.</para>
        /// </summary>
        [JsonProperty("channel_for_external_user_ids")]
        public string ChannelForExternalUserIds { get; set; }

        #endregion

        public CreateNotificationOptions(string appId = null) {
            AppId = appId ?? OneSignalConfiguration.GetAppId();
        }
    }
}
