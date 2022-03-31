using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.CancelOrder
{
    public class Data {
        [JsonProperty("result")]
        public bool Result { get; set; }
    }
}
