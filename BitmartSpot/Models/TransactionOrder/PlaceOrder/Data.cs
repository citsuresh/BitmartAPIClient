using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.PlaceOrder
{
    public class Data {
        [JsonProperty("order_id")]
        public int OrderId { get; set; }
    }
}
