using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneSignal {
    public class AppService : BaseService {
        /// <summary>
        /// Creates a new OneSignal app. If you plan on making requests to the app after created be sure to call OneSignalConfiguration.SetAppId(newApp.Id)
        /// </summary>
        /// <param name="options">Parameters for creating a new app</param>
        /// <returns>Details of the newly created app</returns>
        public async Task<AppResponse> CreateAppAsync(CreateUpdateAppOptions options) {
            return await PostAsync<AppResponse>("apps", options);
        }

        /// <summary>
        /// Creates a new OneSignal app. If you plan on making requests to the app after created be sure to call OneSignalConfiguration.SetAppId(newApp.Id)
        /// </summary>
        /// <param name="options">Parameters for creating a new app</param>
        /// <returns>Details of the newly created app</returns>
        public AppResponse CreateApp(CreateUpdateAppOptions options) {
            return Post<AppResponse>("apps", options);
        }

        /// <summary>
        /// Updates the name or configuration settings of an existing OneSignal app
        /// </summary>
        /// <param name="options">Parameters for updating the current app</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Details of the updated app</returns>
        public async Task<AppResponse> UpdateAppAsync(CreateUpdateAppOptions options, string appId = null) {
            return await PutAsync<AppResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}", options);
        }

        /// <summary>
        /// Updates the name or configuration settings of an existing OneSignal app
        /// </summary>
        /// <param name="options">Parameters for updating the current app</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Details of the updated app</returns>
        public AppResponse UpdateApp(CreateUpdateAppOptions options, string appId = null) {
            return Put<AppResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}", options);
        }

        /// <summary>
        /// View the details of all of your current OneSignal apps
        /// </summary>
        /// <returns>A list of all your apps</returns>
        public async Task<List<AppResponse>> ViewAppsAsync() {
            return await GetAsync<List<AppResponse>>("apps");
        }

        /// <summary>
        /// View the details of all of your current OneSignal apps
        /// </summary>
        /// <returns>A list of all your apps</returns>
        public List<AppResponse> ViewApps() {
            return Get<List<AppResponse>>("apps");
        }

        /// <summary>
        /// View the details of a single OneSignal app
        /// </summary>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Detail of the current app</returns>
        public async Task<AppResponse> ViewAppAsync(string appId = null) {
            return await GetAsync<AppResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}");
        }

        /// <summary>
        /// View the details of a single OneSignal app
        /// </summary>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Detail of the current app</returns>
        public AppResponse ViewApp(string appId = null) {
            return Get<AppResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}");
        }

        /// <summary>
        /// Create segments visible and usable in the dashboard and API - Requires OneSignal Plan
        /// </summary>
        /// <param name="options">Parameters for creating a segment</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Status of the create segment call</returns>
        public async Task<GenericResponse> CreateSegmentAsync(CreateSegmentOptions options, string appId = null) {
            return await PostAsync<GenericResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}/segments", options);
        }

        /// <summary>
        /// Create segments visible and usable in the dashboard and API - Requires OneSignal Plan
        /// </summary>
        /// <param name="options">Parameters for creating a segment</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Status of the create segment call</returns>
        public GenericResponse CreateSegment(CreateSegmentOptions options, string appId = null) {
            return Post<GenericResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}/segments", options);
        }

        /// <summary>
        /// Delete segments (not user devices) - Requires OneSignal Plan
        /// </summary>
        /// <param name="segmentId">Id of the segment you want to delete</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Status of the delete segment call</returns>
        public async Task<GenericResponse> DeleteSegmentAsync(string segmentId, string appId = null) {
            var response = await DeleteAsync<GenericResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}/segments/{segmentId}");
            response.Id = segmentId;
            return response;
        }

        /// <summary>
        /// Delete segments (not user devices) - Requires OneSignal Plan
        /// </summary>
        /// <param name="segmentId">Id of the segment you want to delete</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Status of the delete segment call</returns>
        public GenericResponse DeleteSegment(string segmentId, string appId = null) {
            var response = Delete<GenericResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}/segments/{segmentId}");
            response.Id = segmentId;
            return response;
        }
    }
}
