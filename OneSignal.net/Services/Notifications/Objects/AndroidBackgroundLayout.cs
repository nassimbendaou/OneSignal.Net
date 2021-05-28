using Newtonsoft.Json;

namespace OneSignal {
    public class AndroidBackgroundLayout {
        /// <summary>
        /// <para>Asset file, android resource name, or URL to remote image.</para>
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// <para>Title text color ARGB Hex format. Example(Blue): "FF0000FF".</para>
        /// </summary>
        [JsonProperty("headings_color")]
        public string HeadingsColor { get; set; }

        /// <summary>
        /// <para>Body text color ARGB Hex format. Example(Red): "FFFF0000"</para>
        /// </summary>
        [JsonProperty("contents_color")]
        public string ContentsColor { get; set; }
    }
}
