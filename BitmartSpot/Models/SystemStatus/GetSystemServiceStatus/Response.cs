using Newtonsoft.Json;

namespace BitmartApiClient.Models.SystemStatus.GetSystemServiceStatus {
    public class Response : Model  {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
