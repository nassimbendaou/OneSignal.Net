using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneSignal {
    public class NotificationService : BaseService {
        /// <summary>
        /// The Create Notification method is used when you want your server to programmatically send messages. You may target users in one of three ways using this method: by Segment, by Filter, or by User ID. At least one targeting parameter must be specified.
        /// </summary>
        /// <param name="options">Options for creating your notification</param>
        /// <returns>Response for creating a notification. Will contain any invalid Ids in the error property</returns>
        public async Task<CreateNotificationResponse> CreateAsync(CreateNotificationOptions options) {
            return await PostAsync<CreateNotificationResponse>("notifications", options);
        }

        /// <summary>
        /// The Create Notification method is used when you want your server to programmatically send messages. You may target users in one of three ways using this method: by Segment, by Filter, or by User ID. At least one targeting parameter must be specified.
        /// </summary>
        /// <param name="options">Options for creating your notification</param>
        /// <returns>Response for creating a notification. Will contain any invalid Ids in the error property</returns>
        public CreateNotificationResponse Create(CreateNotificationOptions options) {
            return Post<CreateNotificationResponse>("notifications", options);
        }

        /// <summary>
        /// Stop a scheduled or currently outgoing notification
        /// </summary>
        /// <param name="notificationId">The Id of the notification you would like to cancel</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>If the cancel was successful or not.</returns>
        public async Task<GenericResponse> CancelAsync(string notificationId, string appId = null) {
            var response = await DeleteAsync<GenericResponse>($"notifications/{notificationId}?app_id={appId ?? OneSignalConfiguration.GetAppId()}");
            response.Id = notificationId;
            return response;
        }

        /// <summary>
        /// Stop a scheduled or currently outgoing notification
        /// </summary>
        /// <param name="notificationId">The Id of the notification you would like to cancel</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>If the cancel was successful or not.</returns>
        public GenericResponse Cancel(string notificationId, string appId = null) {
            var response = Delete<GenericResponse>($"notifications/{notificationId}?app_id={appId ?? OneSignalConfiguration.GetAppId()}");
            response.Id = notificationId;
            return response;
        }

        /// <summary>
        /// <para>This method will return all devices that were sent the given notification_id of an Email or Push Notification if used within 7 days of the date sent. After 7 days of the sending date, the message history data will be unavailable.</para>
        /// <para>After a successful response is received, the destination url may be polled until the file becomes available.Most exports are done in ~1-3 minutes, so setting a poll interval of 10 seconds should be adequate.</para>
        /// <para>For use cases that are not meant to be consumed by a script, an email will be sent to the supplied email address.</para>
        /// </summary>
        /// <returns>The history of a notification</returns>
        public async Task<GetNotificationHistoryResponse> GetHistoryAsync(string notificationId, GetNotificationHistoryOptions options) {
            return await PostAsync<GetNotificationHistoryResponse>($"notifications/{notificationId}/history", options);
        }

        /// <summary>
        /// <para>This method will return all devices that were sent the given notification_id of an Email or Push Notification if used within 7 days of the date sent. After 7 days of the sending date, the message history data will be unavailable.</para>
        /// <para>After a successful response is received, the destination url may be polled until the file becomes available.Most exports are done in ~1-3 minutes, so setting a poll interval of 10 seconds should be adequate.</para>
        /// <para>For use cases that are not meant to be consumed by a script, an email will be sent to the supplied email address.</para>
        /// </summary>
        /// <returns>The history of a notification</returns>
        public GetNotificationHistoryResponse GetHistory(string notificationId, GetNotificationHistoryOptions options) {
            return Post<GetNotificationHistoryResponse>($"notifications/{notificationId}/history", options);
        }

        /// <summary>
        /// View the details of multiple notifications
        /// </summary>
        /// <param name="kind">The kind of notification (Dashboard, Api, or Automated)</param>
        /// <param name="limit">The number of notifications per page</param>
        /// <param name="offset">The number of notifications to skip</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Paginated list of notifications</returns>
        public async Task<ViewNotificationsResponse> ViewNotificationsAsync(NotificationKind kind, int limit = 50, int offset = 0, string appId = null) {
            return await GetAsync<ViewNotificationsResponse>($"notifications?app_id={appId ?? OneSignalConfiguration.GetAppId()}&limit={limit}&offset={offset}&kind={kind}");
        }

        /// <summary>
        /// View the details of multiple notifications
        /// </summary>
        /// <param name="kind">The kind of notification (Dashboard, Api, or Automated)</param>
        /// <param name="limit">The number of notifications per page</param>
        /// <param name="offset">The number of notifications to skip</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Paginated list of notifications</returns>
        public ViewNotificationsResponse ViewNotifications(NotificationKind kind, int limit = 50, int offset = 0, string appId = null) {
            return Get<ViewNotificationsResponse>($"notifications?app_id={appId ?? OneSignalConfiguration.GetAppId()}&limit={limit}&offset={offset}&kind={kind}");
        }

        /// <summary>
        /// View the details of a single notification and outcomes associated with it
        /// </summary>
        /// <param name="notificationId">The id of the notification</param>
        /// <param name="outcomeNames">List of names and the value (sum/count) for the returned outcome data. For out-of-the-box OneSignal outcomes such as click and session duration, please use the “os” prefix with two underscores. For other outcomes, please use the name specified by the user.</param>
        /// <param name="outcomeTimeRange">Time range for the returned data. The values can be 1h (for the last 1 hour data), 1d (for the last 1 day data), or 1mo (for the last 1 month data).</param>
        /// <param name="outcomePlatforms">Default is data from all platforms if the parameter is omitted.</param>
        /// <param name="outcomeAttribution">Attribution type for the outcomes. The values can be direct or influenced.</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Notification details</returns>
        public async Task<NotificationResponse> ViewNotificationAsync(string notificationId, List<string> outcomeNames = null, OutcomeTimeRange outcomeTimeRange = OutcomeTimeRange.OneHour, List<DeviceType> outcomePlatforms = null, OutcomeAttribution outcomeAttribution = OutcomeAttribution.Total, string appId = null) {
            var url = $"notifications/{notificationId}?app_id={appId ?? OneSignalConfiguration.GetAppId()}";
            if(outcomeNames != null && outcomeNames.Any()) {
                url += BuildOutcomes(false, outcomeNames, outcomeTimeRange, outcomePlatforms, outcomeAttribution);
            }

            return await GetAsync<NotificationResponse>(url);
        }

        /// <summary>
        /// View the details of a single notification and outcomes associated with it
        /// </summary>
        /// <param name="notificationId">The id of the notification</param>
        /// <param name="outcomeNames">List of names and the value (sum/count) for the returned outcome data. For out-of-the-box OneSignal outcomes such as click and session duration, please use the “os” prefix with two underscores. For other outcomes, please use the name specified by the user.</param>
        /// <param name="outcomeTimeRange">Time range for the returned data. The values can be 1h (for the last 1 hour data), 1d (for the last 1 day data), or 1mo (for the last 1 month data).</param>
        /// <param name="outcomePlatforms">Default is data from all platforms if the parameter is omitted.</param>
        /// <param name="outcomeAttribution">Attribution type for the outcomes. The values can be direct or influenced.</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Notification details</returns>
        public NotificationResponse ViewNotification(string notificationId, List<string> outcomeNames = null, OutcomeTimeRange outcomeTimeRange = OutcomeTimeRange.OneHour, List<DeviceType> outcomePlatforms = null, OutcomeAttribution outcomeAttribution = OutcomeAttribution.Total, string appId = null) {
            var url = $"notifications/{notificationId}?app_id={appId ?? OneSignalConfiguration.GetAppId()}";
            if (outcomeNames != null && outcomeNames.Any()) {
                url += BuildOutcomes(false, outcomeNames, outcomeTimeRange, outcomePlatforms, outcomeAttribution);
            }

            return Get<NotificationResponse>(url);
        }

        /// <summary>
        /// View the details of all the outcomes associated with your app
        /// </summary>
        /// <param name="outcomeNames">List of names and the value (sum/count) for the returned outcome data. For out-of-the-box OneSignal outcomes such as click and session duration, please use the “os” prefix with two underscores. For other outcomes, please use the name specified by the user.</param>
        /// <param name="outcomeTimeRange">Time range for the returned data. The values can be 1h (for the last 1 hour data), 1d (for the last 1 day data), or 1mo (for the last 1 month data).</param>
        /// <param name="outcomePlatforms">Default is data from all platforms if the parameter is omitted.</param>
        /// <param name="outcomeAttribution">Attribution type for the outcomes. The values can be direct or influenced.</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>App outcomes</returns>
        public async Task<NotificationOutcomeResponse> ViewOutcomesAsync(List<string> outcomeNames, OutcomeTimeRange outcomeTimeRange = OutcomeTimeRange.OneHour, List<DeviceType> outcomePlatforms = null, OutcomeAttribution outcomeAttribution = OutcomeAttribution.Total, string appId = null) {
            var url = $"apps/{appId ?? OneSignalConfiguration.GetAppId()}/outcomes{BuildOutcomes(true, outcomeNames, outcomeTimeRange, outcomePlatforms, outcomeAttribution)}";

            return await GetAsync<NotificationOutcomeResponse>(url);
        }

        /// <summary>
        /// View the details of all the outcomes associated with your app
        /// </summary>
        /// <param name="outcomeNames">List of names and the value (sum/count) for the returned outcome data. For out-of-the-box OneSignal outcomes such as click and session duration, please use the “os” prefix with two underscores. For other outcomes, please use the name specified by the user.</param>
        /// <param name="outcomeTimeRange">Time range for the returned data. The values can be 1h (for the last 1 hour data), 1d (for the last 1 day data), or 1mo (for the last 1 month data).</param>
        /// <param name="outcomePlatforms">Default is data from all platforms if the parameter is omitted.</param>
        /// <param name="outcomeAttribution">Attribution type for the outcomes. The values can be direct or influenced.</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>App outcomes</returns>
        public NotificationOutcomeResponse ViewOutcomes(List<string> outcomeNames, OutcomeTimeRange outcomeTimeRange = OutcomeTimeRange.OneHour, List<DeviceType> outcomePlatforms = null, OutcomeAttribution outcomeAttribution = OutcomeAttribution.Total, string appId = null) {
            var url = $"apps/{appId ?? OneSignalConfiguration.GetAppId()}/outcomes{BuildOutcomes(true, outcomeNames, outcomeTimeRange, outcomePlatforms, outcomeAttribution)}";
            return Get<NotificationOutcomeResponse>(url);
        }

        private static string BuildOutcomes(bool includeUrlStart, List<string> outcomeNames, OutcomeTimeRange outcomeTimeRange = OutcomeTimeRange.OneHour, List<DeviceType> outcomePlatforms = null, OutcomeAttribution outcomeAttribution = OutcomeAttribution.Total) {
            var url = string.Empty;
            var urlStart = includeUrlStart ? "?" : "";
            var rawOutcomeNames = string.Join("&outcome_names[]=", outcomeNames);
            var outcomeNamesFormatted = includeUrlStart ? rawOutcomeNames : rawOutcomeNames.Trim('&');
            url += $"{urlStart}{outcomeNamesFormatted}";
            url += $"&outcome_time_range={outcomeTimeRange.ToEnumMemberAttrValue()}";
            if (outcomePlatforms != null && outcomePlatforms.Any()) {
                url += $"&outcome_platforms={string.Join(",", outcomePlatforms)}";
            }
            url += $"&outcome_attribution={outcomeAttribution.ToString().ToLower()}";

            return url;
        }
    }
}
