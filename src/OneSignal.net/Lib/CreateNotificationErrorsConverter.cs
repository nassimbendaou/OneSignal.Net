using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OneSignal {
    class CreateNotificationErrorsConverter : JsonConverter {
        public override bool CanConvert(Type objectType) => true;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var token = JToken.Load(reader);
            if(token.Type == JTokenType.Array) {
                return new CreateNotificationErrors {
                    ErrorMessages = token.ToObject<List<string>>()
                };
            }

            return token.ToObject<CreateNotificationErrors>();
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }
    }
}
