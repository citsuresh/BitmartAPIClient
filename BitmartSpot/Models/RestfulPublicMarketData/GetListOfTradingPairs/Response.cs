using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairs {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
