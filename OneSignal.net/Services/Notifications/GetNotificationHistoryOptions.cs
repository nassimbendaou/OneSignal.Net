using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OneSignal {
    public class GetNotificationHistoryOptions : BaseOptions {
        [JsonProperty("app_id")]
        public string AppId { get; private set; }

        /// <summary>
        /// The email address you would like the report sent
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// <para>"sent" - All the devices by player_id that were sent the specified notification_id. Notifications targeting under 1000 recipients will not have "sent" events recorded, but will show "clicked" events.</para>
        /// <para>"clicked" - All the devices by player_id that clicked the specified notification_id.</para>
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("events")]
        public NotificationEvent Events { get; set; }

        public GetNotificationHistoryOptions(string appId = null) {
            AppId = appId ?? OneSignalConfiguration.GetAppId();
        }
    }
}
