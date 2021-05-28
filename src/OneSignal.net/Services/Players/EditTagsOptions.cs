using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class EditTagsOptions : BaseOptions {
        /// <summary>
        /// <para>Custom tags for the device record.</para>
        /// <para>Limitations:</para>
        /// <para>- 100 tags per call</para>
        /// <para>- Android SDK users: tags cannot be removed or changed via API if set through SDK sendTag methods.</para>
        /// </summary>
        [JsonProperty("tags")]
        public Dictionary<string, string> Tags { get; set; }
    }
}
