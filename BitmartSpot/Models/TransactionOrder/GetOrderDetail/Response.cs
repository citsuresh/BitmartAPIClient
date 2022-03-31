using Newtonsoft.Json;
namespace BitmartApiClient.Models.TransactionOrder.GetOrderDetail {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
