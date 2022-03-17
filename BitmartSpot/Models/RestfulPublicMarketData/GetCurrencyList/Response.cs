using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetCurrencyList {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
