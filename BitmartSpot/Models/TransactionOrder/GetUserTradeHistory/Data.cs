using Newtonsoft.Json;

namespace BitmartApiClient.Models.TransactionOrder.GetUserTradeHistory
{
    public class Data {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("trades")]
        public List<Trade> Trades { get; set; }

        [JsonProperty("server_time")]
        public long ServerTime { get; set; }
    }
}
