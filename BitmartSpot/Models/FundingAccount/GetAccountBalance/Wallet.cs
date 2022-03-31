using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetAccountBalance
{
    public class Wallet {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("available")]
        public string Available { get; set; }

        [JsonProperty("frozen")]
        public string Frozen { get; set; }
    }
}
