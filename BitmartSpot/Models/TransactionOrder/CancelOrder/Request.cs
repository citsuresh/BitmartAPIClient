using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.CancelOrder {
    public class Request {
        [JsonProperty("order_id")]
        public long OrderId { get; set; }
        public static Request New(long anOrderId) => new Request(anOrderId);

        private Request(long anOrderId) {
            OrderId = anOrderId;
        }
    }
}
