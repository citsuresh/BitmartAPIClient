using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.BatchOrder
{
    public class Data2 {
        [JsonProperty("orderId")]
        public int OrderId { get; set; }
    }
}
