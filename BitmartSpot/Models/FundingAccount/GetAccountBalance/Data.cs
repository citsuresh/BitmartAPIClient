using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetAccountBalance
{
    public class Data {
        [JsonProperty("wallet")]
        public List<Wallet> Wallet { get; set; }
    }
}
