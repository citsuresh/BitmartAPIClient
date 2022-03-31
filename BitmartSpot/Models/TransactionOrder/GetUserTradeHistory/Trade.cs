using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.GetUserTradeHistory {
    public class Trade {
        [JsonProperty("detail_id")]
        public int DetailId { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("create_time")]
        public long CreateTime { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("fees")]
        public string Fees { get; set; }

        [JsonProperty("fee_coin_name")]
        public string FeeCoinName { get; set; }

        [JsonProperty("notional")]
        public string Notional { get; set; }

        [JsonProperty("price_avg")]
        public string PriceAvg { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("exec_type")]
        public string ExecType { get; set; }
    }
}
