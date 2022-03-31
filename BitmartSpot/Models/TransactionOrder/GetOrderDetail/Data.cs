using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.GetOrderDetail
{
    public class Data {
        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("create_time")]
        public long CreateTime { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_avg")]
        public string PriceAvg { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("notional")]
        public string Notional { get; set; }

        [JsonProperty("filled_notional")]
        public string FilledNotional { get; set; }

        [JsonProperty("filled_size")]
        public string FilledSize { get; set; }

        [JsonProperty("unfilled_volume")]
        public string UnfilledVolume { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
