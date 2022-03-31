using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.BatchOrder {
    public class Request {
        [JsonProperty("orderParams")]
        public List<OrderParam> OrderParams { get; set; }
        public static Request New(List<OrderParam> someOrderParams) => new Request(someOrderParams);

        private Request(List<OrderParam> someOrderParams) {
            OrderParams = someOrderParams;
        }
    }
}
