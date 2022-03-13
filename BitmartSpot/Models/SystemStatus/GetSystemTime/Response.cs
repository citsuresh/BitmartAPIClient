using Newtonsoft.Json;

namespace BitmartApiClient.Models.SystemStatus.GetSystemTime {
    public class Response : Model  {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
