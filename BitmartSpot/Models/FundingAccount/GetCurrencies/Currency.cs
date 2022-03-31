using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetCurrencies {
    public class Currency {
        [JsonProperty("currency")]
        public string CurrencyPair { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("withdraw_enabled")]
        public bool WithdrawEnabled { get; set; }

        [JsonProperty("deposit_enabled")]
        public bool DepositEnabled { get; set; }
    }
}
