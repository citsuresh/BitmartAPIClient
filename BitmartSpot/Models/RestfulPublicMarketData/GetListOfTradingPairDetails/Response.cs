using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairDetails {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
