using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.GetUserOrderHistory {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
