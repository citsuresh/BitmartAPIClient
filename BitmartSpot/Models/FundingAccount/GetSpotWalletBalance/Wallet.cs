using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetSpotWalletBalance
{
    public class Wallet {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("available")]
        public string Available { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("frozen")]
        public string Frozen { get; set; }
    }
}
