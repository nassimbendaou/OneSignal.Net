using System.Threading.Tasks;

namespace OneSignal {
    public class PlayerService : BaseService {
        /// <summary>
        /// Register a new device to one of your OneSignal apps
        /// </summary>
        /// <param name="options">Parameters for adding a device</param>
        /// <returns>The status and id of the new device</returns>
        public async Task<GenericResponse> AddDeviceAsync(CreateUpdateDeviceOptions options) {
            return await PostAsync<GenericResponse>("players", options);
        }

        /// <summary>
        /// Register a new device to one of your OneSignal apps
        /// </summary>
        /// <param name="options">Parameters for adding a device</param>
        /// <returns>The status and id of the new device</returns>
        public GenericResponse AddDevice(CreateUpdateDeviceOptions options) {
            return Post<GenericResponse>("players", options);
        }

        /// <summary>
        /// Update an existing device in one of your OneSignal apps
        /// </summary>
        /// <param name="deviceId">The id of the device you want to edit</param>
        /// <param name="options">Parameters for editing the device</param>
        /// <returns>The status and id of the edited device</returns>
        public async Task<GenericResponse> EditDeviceAsync(string deviceId, CreateUpdateDeviceOptions options) {
            var response = await PutAsync<GenericResponse>($"players/{deviceId}", options);
            response.Id = deviceId;
            return response;
        }

        /// <summary>
        /// Update an existing device in one of your OneSignal apps
        /// </summary>
        /// <param name="deviceId">The id of the device you want to edit</param>
        /// <param name="options">Parameters for editing the device</param>
        /// <returns>The status and id of the edited device</returns>
        public GenericResponse EditDevice(string deviceId, CreateUpdateDeviceOptions options) {
            var response = Put<GenericResponse>($"players/{deviceId}", options);
            response.Id = deviceId;
            return response;
        }

        /// <summary>
        /// <para>View the details of multiple devices in one of your OneSignal apps</para>
        /// <para>For performance reasons, this method is not available for larger apps. Larger apps should use the CSV export API endpoint, which is much more performant.</para>
        /// </summary>
        /// <param name="limit">Number of devices per page: Default and Max are 300</param>
        /// <param name="offset">Offset for pagination</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>A list of devices</returns>
        public async Task<DeviceListResponse> ViewDevicesAsync(int limit = 300, int offset = 0, string appId = null) {
            return await GetAsync<DeviceListResponse>($"players?app_id={appId ?? OneSignalConfiguration.GetAppId()}&limit={limit}&offset={offset}");
        }

        /// <summary>
        /// <para>View the details of multiple devices in one of your OneSignal apps</para>
        /// <para>For performance reasons, this method is not available for larger apps. Larger apps should use the CSV export API endpoint, which is much more performant.</para>
        /// </summary>
        /// <param name="limit">Number of devices per page: Default and Max are 300</param>
        /// <param name="offset">Offset for pagination</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>A list of devices</returns>
        public DeviceListResponse ViewDevices(int limit = 300, int offset = 0, string appId = null) {
            return Get<DeviceListResponse>($"players?app_id={appId ?? OneSignalConfiguration.GetAppId()}&limit={limit}&offset={offset}");
        }

        /// <summary>
        /// View the details of an existing device in one of your OneSignal apps
        /// </summary>
        /// <param name="playerId">The id of the device you want to view</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Device details</returns>
        public async Task<DeviceResponse> ViewDeviceAsync(string playerId, string appId = null) {
            return await GetAsync<DeviceResponse>($"players/{playerId}?app_id={appId ?? OneSignalConfiguration.GetAppId()}");
        }

        /// <summary>
        /// View the details of an existing device in one of your OneSignal apps
        /// </summary>
        /// <param name="playerId">The id of the device you want to view</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Device details</returns>
        public DeviceResponse ViewDevice(string playerId, string appId = null) {
            return Get<DeviceResponse>($"players/{playerId}?app_id={appId ?? OneSignalConfiguration.GetAppId()}");
        }

        /// <summary>
        /// Update an existing device's tags in one of your OneSignal apps using the External User ID.
        /// </summary>
        /// <param name="externalUserId">Required: The OneSignal App ID the user record is found under.</param>
        /// <param name="options">Tags to update with</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Status of update</returns>
        public async Task<GenericResponse> EditTagsWithExternalUserIdAsync(string externalUserId, EditTagsOptions options, string appId = null) {
            return await PutAsync<GenericResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}/users/{externalUserId}", options);
        }

        /// <summary>
        /// Update an existing device's tags in one of your OneSignal apps using the External User ID.
        /// </summary>
        /// <param name="externalUserId">Required: The OneSignal App ID the user record is found under.</param>
        /// <param name="options">Tags to update with</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>Status of update</returns>
        public GenericResponse EditTagsWithExternalUserId(string externalUserId, EditTagsOptions options, string appId = null) {
            return Put<GenericResponse>($"apps/{appId ?? OneSignalConfiguration.GetAppId()}/users/{externalUserId}", options);
        }

        /// <summary>
        /// <para>Update a device's session information</para>
        /// <para>This method should be called when a device opens your app after they are already registered. This method will automatically increment the player's session_count, and should also be used to update any fields that may have changed (such as language or timezone).</para>
        /// <para>If a player record is not found, a new one will be created if and only if the request includes a device_type.</para>
        /// </summary>
        /// <param name="playerId">Player id to add a new session to</param>
        /// <param name="options">Parameters for creating a new session</param>
        /// <returns>Status of new session request</returns>
        public async Task<GenericResponse> NewSessionAsync(string playerId, NewSessionOptions options) {
            var response = await PostAsync<GenericResponse>($"players/{playerId}/on_session", options);
            response.Id = playerId;
            return response;
        }

        /// <summary>
        /// <para>Update a device's session information</para>
        /// <para>This method should be called when a device opens your app after they are already registered. This method will automatically increment the player's session_count, and should also be used to update any fields that may have changed (such as language or timezone).</para>
        /// <para>If a player record is not found, a new one will be created if and only if the request includes a device_type.</para>
        /// </summary>
        /// <param name="playerId">Player id to add a new session to</param>
        /// <param name="options">Parameters for creating a new session</param>
        /// <returns>Status of new session request</returns>
        public GenericResponse NewSession(string playerId, NewSessionOptions options) {
            var response = Post<GenericResponse>($"players/{playerId}/on_session", options);
            response.Id = playerId;
            return response;
        }

        /// <summary>
        /// Track a new purchase in your app
        /// </summary>
        /// <param name="playerId">Player id to add a new session to</param>
        /// <param name="options">Parameters for creating a new purchase</param>
        /// <returns>Status of new purchase request</returns>
        public async Task<GenericResponse> NewPurchaseAsync(string playerId, NewPurchaseOptions options) {
            var response = await PostAsync<GenericResponse>($"players/{playerId}/on_purchase", options);
            response.Id = playerId;
            return response;
        }

        /// <summary>
        /// Track a new purchase in your app
        /// </summary>
        /// <param name="playerId">Player id to add a new session to</param>
        /// <param name="options">Parameters for creating a new purchase</param>
        /// <returns>Status of new purchase request</returns>
        public GenericResponse NewPurchase(string playerId, NewPurchaseOptions options) {
            var response = Post<GenericResponse>($"players/{playerId}/on_purchase", options);
            response.Id = playerId;
            return response;
        }

        /// <summary>
        /// <para>Generate a compressed CSV export of all of your current user data</para>
        /// <para>This method can be used to generate a compressed CSV export of all of your current user data. It is a much faster alternative than retrieving this data using the /players API endpoint.</para>
        /// <para>The file will be compressed using GZip.</para>
        /// <para>The file may take several minutes to generate depending on the number of users in your app.</para>
        /// <para>The URL generated will be available for 3 days and includes random v4 uuid as part of the resource name to be unguessable.</para>
        /// </summary>
        /// <param name="options">Parameters for CSV export</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>URL to download CSV export file</returns>
        public async Task<CsvExportResponse> CsvExportAsync(CsvExportOptions options, string appId = null) {
            return await PostAsync<CsvExportResponse>($"players/csv_export?app_id={appId ?? OneSignalConfiguration.GetAppId()}", options);
        }

        /// <summary>
        /// <para>Generate a compressed CSV export of all of your current user data</para>
        /// <para>This method can be used to generate a compressed CSV export of all of your current user data. It is a much faster alternative than retrieving this data using the /players API endpoint.</para>
        /// <para>The file will be compressed using GZip.</para>
        /// <para>The file may take several minutes to generate depending on the number of users in your app.</para>
        /// <para>The URL generated will be available for 3 days and includes random v4 uuid as part of the resource name to be unguessable.</para>
        /// </summary>
        /// <param name="options">Parameters for CSV export</param>
        /// <param name="appId">Optional app id if you want an app id different than what is defined in OneSignalConfiguration</param>
        /// <returns>URL to download CSV export file</returns>
        public CsvExportResponse CsvExport(CsvExportOptions options, string appId = null) {
            return Post<CsvExportResponse>($"players/csv_export?app_id={appId ?? OneSignalConfiguration.GetAppId()}", options);
        }
    }
}
