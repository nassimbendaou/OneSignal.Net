using Newtonsoft.Json;

namespace OneSignal {
    public class NotificationFilterOperator : NotificationFilter {
        [JsonProperty("operator")]
        public string Operator { get; private set; }

        public NotificationFilterOperator(string op) {
            Operator = op;
        }

        public static NotificationFilterOperator AND => new NotificationFilterOperator("AND");
        public static NotificationFilterOperator OR => new NotificationFilterOperator("OR");
    }
}
