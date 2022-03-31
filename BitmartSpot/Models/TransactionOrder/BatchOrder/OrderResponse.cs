using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.BatchOrder {
    public class OrderResponse {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public Data2 Data { get; set; }
    }
}
