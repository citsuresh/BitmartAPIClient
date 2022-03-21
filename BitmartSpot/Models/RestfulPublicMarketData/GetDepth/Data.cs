using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetDepth {
    public class Data {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("buys")]
        public List<Buy> Buys { get; set; }

        [JsonProperty("sells")]
        public List<Sell> Sells { get; set; }
    }
}
