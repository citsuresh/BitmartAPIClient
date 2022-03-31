using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.CancelOrder {
    public class Request {
        [JsonProperty("order_id")]
        public int OrderId { get; set; }
        public static Request New(int anOrderId) => new Request(anOrderId);

        private Request(int anOrderId) {
            OrderId = anOrderId;
        }
    }
}
