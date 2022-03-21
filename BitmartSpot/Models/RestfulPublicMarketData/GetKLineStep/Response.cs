using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetKLineStep {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
