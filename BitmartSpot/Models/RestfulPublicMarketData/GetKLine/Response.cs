using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetKLine {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
