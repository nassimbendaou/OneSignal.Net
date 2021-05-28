namespace OneSignal {
    public static class OneSignalConfiguration {
        private static string _apiKey;
        private static string _appId;
        private static string _basePath = "https://onesignal.com/api/v1/";

        internal static string GetApiKey() {
            return _apiKey;
        }

        /// <summary>
        /// Sets the API key that will be used for all requests
        /// </summary>
        /// <param name="newApiKey">OneSignal API key</param>
        public static void SetupApiKey(string newApiKey) {
            _apiKey = newApiKey;
        }

        internal static string GetAppId() {
            return _appId;
        }

        /// <summary>
        /// Sets the App Id to be used for all requests (all requests that require an app Id take an optional app id to override this configuration
        /// </summary>
        /// <param name="appId">OneSignal App Id</param>
        public static void SetupAppId(string appId) {
            _appId = appId;
        }

        internal static string GetBasePath() {
            return _basePath;
        }

        /// <summary>
        /// Sets the base path to the API. This is set automatically and only needs to be changed if using a different API version.
        /// </summary>
        /// <param name="newBase"></param>
        public static void SetBasePath(string newBase) {
            _basePath = newBase;
        }

        public static string GetSdkName() => "OneSignal C# API Client: v1.0.0";
    }
}
