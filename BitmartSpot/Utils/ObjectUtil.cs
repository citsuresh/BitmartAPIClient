using Newtonsoft.Json;

namespace BitmartApiClient.Utils {
    public static class ObjectUtil {
        public static string ToJsonString(this object anObj) => JsonConvert.SerializeObject(anObj, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        });
    }
}