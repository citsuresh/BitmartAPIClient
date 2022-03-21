using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetTicker {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
