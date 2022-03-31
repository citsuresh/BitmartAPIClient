using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.GetUserOrderHistory
{
    public class Data {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }
    }
}
