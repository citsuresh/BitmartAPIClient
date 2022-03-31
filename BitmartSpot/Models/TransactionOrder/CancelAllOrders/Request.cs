using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.CancelAllOrders {
    public class Request {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
        public static Request New(string symbol, string side) => new Request(symbol, side);

        private Request(string aSymbol, string aSide) {
            Symbol = aSymbol;
            Side = aSide;
        }
    }
}
