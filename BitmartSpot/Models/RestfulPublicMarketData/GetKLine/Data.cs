using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetKLine {
    public class Data {
        [JsonProperty("klines")]
        public List<KLine> Klines { get; set; }
    }
}
