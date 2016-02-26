using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ShinyTrain.Helpers
{
    public static class JsonHelpers
    {
        public static string AsJSON(this object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.Indented,
                new JsonSerializerSettings() {ContractResolver = new CamelCasePropertyNamesContractResolver()});
        }
    }
}