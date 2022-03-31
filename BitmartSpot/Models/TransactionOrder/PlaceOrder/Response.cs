using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.PlaceOrder {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
