using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairDetails {
    public class Data {
        [JsonProperty("symbols")]
        public List<Symbol> Symbols { get; set; }
    }
}
