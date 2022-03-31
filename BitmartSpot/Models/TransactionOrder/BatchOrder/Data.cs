using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.BatchOrder
{
    public class Data {
       
        [JsonProperty("orderResponses")]
        public List<OrderResponse> OrderResponses { get; set; }
    }
}
