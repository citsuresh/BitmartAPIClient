using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetKLineStep {
    public class Data {
        [JsonProperty("steps")]
        public List<int> Steps { get; set; }
    }
}
