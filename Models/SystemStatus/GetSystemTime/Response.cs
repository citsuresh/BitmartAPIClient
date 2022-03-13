using Newtonsoft.Json;

namespace BitmartApiClient.Models.SystemStatus.GetSystemTime {
    public class Response : Model<Response> {
        [JsonProperty("server_time")]
        public long ServerTime { get; set; }
    }
}
