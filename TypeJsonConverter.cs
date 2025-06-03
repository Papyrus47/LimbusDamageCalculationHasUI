using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbusDamageCalculationHasUI
{
    public class TypeJsonConverter : JsonConverter<Type>
    {
        public override Type ReadJson(JsonReader reader, Type objectType, Type existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var typeName = JToken.Load(reader).Value<string>();
            return Type.GetType(typeName);
        }

        public override void WriteJson(JsonWriter writer, Type value, JsonSerializer serializer)
        {
            writer.WriteValue(value.AssemblyQualifiedName);
        }
    }

}
