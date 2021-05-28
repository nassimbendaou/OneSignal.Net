using Newtonsoft.Json;

namespace OneSignal {
    public class CsvExportResponse {
        /// <summary>
        /// The URL where the CSV export can be downloaded
        /// </summary>
        [JsonProperty("csv_file_url")]
        public string CsvFileUrl { get; set; }
    }
}
