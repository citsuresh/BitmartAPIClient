using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairs {
    public class Data {
        [JsonProperty("symbols")]
        public List<string> Symbols { get; set; }
    }
}
