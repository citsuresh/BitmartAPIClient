using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetTradeFee
{
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
