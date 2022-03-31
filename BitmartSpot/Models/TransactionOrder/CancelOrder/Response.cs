using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.CancelOrder {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
