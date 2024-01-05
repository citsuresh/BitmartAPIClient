using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetTradeFee
{
    public class Trade {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("order_time")]
        public long OrderTime { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
