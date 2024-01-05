using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetTradeFee {
    public class Data
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("buy_taker_fee_rate")]
        public string BuyTakerFeeRate { get; set; }

        [JsonProperty("sell_taker_fee_rate")]
        public string SellTakerFeeRate { get; set; }

        [JsonProperty("buy_maker_fee_rate")]
        public string BuyMakerFeeRate { get; set; }

        [JsonProperty("sell_maker_fee_rate")]
        public string SellMakerFeeRate { get; set; }
    }
}
