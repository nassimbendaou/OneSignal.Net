using Newtonsoft.Json;
using System.Collections.Generic;

namespace OneSignal {
    public class CreateSegmentOptions : BaseOptions {
        /// <summary>
        /// UUID of the segment. If left empty, it will be assigned automatically.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the segment you're creating. You'll see this name on the web UI.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// <para>Filters or operators the segment will have. The following are filter options:</para>
        /// NotificationFilterAmountSpent - Amount in USD a user has spent on in app purchases<br />
        /// NotificationFilterAppVersion - Users that have the target app version<br />
        /// NotificationFilterBoughtSku - Amount a user has spent on a specific SKU as an in app purchase<br />
        /// NotificationFilterCountry - Users that are in a specific country<br />
        /// NotificationFilterEmail - Use this for targeting push subscribers associated with an email set with all SDK setEmail methods<br />
        /// NotificationFilterFirstSession - Number of hours before or after the users first session<br />
        /// NotificationFilterLanguage - Users with their device set to a specific language<br />
        /// NotificationFilterLastSession - Number of hours before or after the users last session<br />
        /// NotificationFilterLocation - Users within a specific distance from a latitude and longitude location<br />
        /// NotificationFilterOperator - Allows for specifying an OR operator between filters which are AND by default<br />
        /// NotificationFilterSessionCount - Number of session a user has<br />
        /// NotificationFilterTag - Filter users based on tags
        /// </summary>
        [JsonProperty("filters")]
        public List<NotificationFilter> Filters { get; set; }
    }
}
