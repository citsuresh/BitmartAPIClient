using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetRecentTrades {
    public class Data {
        [JsonProperty("trades")]
        public List<Trade> Trades { get; set; }
    }
}
