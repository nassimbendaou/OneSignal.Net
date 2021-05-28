using Newtonsoft.Json;

namespace OneSignal {
    public class BaseOptions {
        public string ToJson() {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
