using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.PlaceOrder {
    public class Request {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("notional")]
        public string Notional { get; set; }
        public static Request New(string aSymbol, string aSide, string aType, string aSize, string aPrice, string aNotional) => new Request {
            Symbol = aSymbol,
            Side = aSide,
            Type = aType,
            Size = aSize,
            Price = aPrice,
            Notional = aNotional
        };
    }
}
