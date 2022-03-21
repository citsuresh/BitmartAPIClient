using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetDepth {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
