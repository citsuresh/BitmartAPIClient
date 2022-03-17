using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetCurrencyList {
    public class Data {
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }
    }
}
