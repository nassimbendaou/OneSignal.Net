using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace OneSignal {
    public class CsvExportOptions : BaseOptions {
        /// <summary>
        /// Additional fields that you wish to include. Currently supports location, country, rooted, notification_types, ip, external_user_id, web_auth, and web_p256.
        /// </summary>
        [JsonProperty("extra_fields")]
        public List<string> ExtraFields { get; set; }

        /// <summary>
        /// Export all devices with a last_active timestamp greater than this time.
        /// </summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [JsonProperty("last_active_since")]
        public DateTime? LastActiveSince { get; set; }

        /// <summary>
        /// Export all devices belong to the segment
        /// </summary>
        [JsonProperty("segment_name")]
        public string SegmentName { get; set; }
    }
}
