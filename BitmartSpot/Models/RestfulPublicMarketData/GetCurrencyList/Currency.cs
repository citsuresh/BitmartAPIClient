using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetCurrencyList {
    public class Currency {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("withdraw_enabled")]
        public bool WithdrawEnabled { get; set; }

        [JsonProperty("deposit_enabled")]
        public bool DepositEnabled { get; set; }
    }
}
