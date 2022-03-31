using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.BatchOrder {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
