using Newtonsoft.Json;

namespace BitmartApiClient.Models.SystemStatus.GetSystemTime {
    public class Data {
        [JsonProperty("server_time")]
        public long ServerTime { get; set; }
    }
}
