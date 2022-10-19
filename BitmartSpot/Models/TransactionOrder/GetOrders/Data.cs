using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.GetOrders
{
    public class Data
    {
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }
    }
}
