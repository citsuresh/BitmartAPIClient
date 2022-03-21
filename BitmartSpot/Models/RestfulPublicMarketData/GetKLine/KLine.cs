using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetKLine {
    public class KLine {
        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }

        [JsonProperty("high")]
        public string High { get; set; }

        [JsonProperty("low")]
        public string Low { get; set; }

        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("last_price")]
        public string LastPrice { get; set; }

        [JsonProperty("volume")]
        public string Volume { get; set; }

        [JsonProperty("quote_volume")]
        public string QuoteVolume { get; set; }
    }
}
