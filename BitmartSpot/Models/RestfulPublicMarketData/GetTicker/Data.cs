using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetTicker {
    public class Data {
        [JsonProperty("tickers")]
        public List<Ticker> Tickers { get; set; }
    }
}
