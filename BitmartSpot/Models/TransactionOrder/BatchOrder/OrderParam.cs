using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.BatchOrder {
    public class OrderParam {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
