using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetTicker {
    public class Ticker {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("last_price")]
        public string LastPrice { get; set; }

        [JsonProperty("quote_volume_24h")]
        public string QuoteVolume24h { get; set; }

        [JsonProperty("base_volume_24h")]
        public string BaseVolume24h { get; set; }

        [JsonProperty("high_24h")]
        public string High24h { get; set; }

        [JsonProperty("low_24h")]
        public string Low24h { get; set; }

        [JsonProperty("open_24h")]
        public string Open24h { get; set; }

        [JsonProperty("close_24h")]
        public string Close24h { get; set; }

        [JsonProperty("best_ask")]
        public string BestAsk { get; set; }

        [JsonProperty("best_ask_size")]
        public string BestAskSize { get; set; }

        [JsonProperty("best_bid")]
        public string BestBid { get; set; }

        [JsonProperty("best_bid_size")]
        public string BestBidSize { get; set; }

        [JsonProperty("fluctuation")]
        public string Fluctuation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
