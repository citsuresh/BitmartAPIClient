using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairDetails {
    public class Symbol {
        [JsonProperty("symbol")]
        public string Name { get; set; }

        [JsonProperty("symbol_id")]
        public int SymbolId { get; set; }

        [JsonProperty("base_currency")]
        public string BaseCurrency { get; set; }

        [JsonProperty("quote_currency")]
        public string QuoteCurrency { get; set; }

        [JsonProperty("quote_increment")]
        public string QuoteIncrement { get; set; }

        [JsonProperty("base_min_size")]
        public string BaseMinSize { get; set; }

        [JsonProperty("base_max_size")]
        public string BaseMaxSize { get; set; }

        [JsonProperty("price_min_precision")]
        public int PriceMinPrecision { get; set; }

        [JsonProperty("price_max_precision")]
        public int PriceMaxPrecision { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("min_buy_amount")]
        public string MinBuyAmount { get; set; }

        [JsonProperty("min_sell_amount")]
        public string MinSellAmount { get; set; }

        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }
    }
}
