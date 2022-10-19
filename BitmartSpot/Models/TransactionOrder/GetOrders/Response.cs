using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.GetOrders
{
    public class Response : Model
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
