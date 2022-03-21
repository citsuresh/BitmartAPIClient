using Newtonsoft.Json;
namespace BitmartApiClient.Models.RestfulPublicMarketData.GetDepth {
    public class Sell {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }
    }
}
