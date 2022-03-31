using Newtonsoft.Json;
namespace BitmartApiClient.Models.FundingAccount.GetDepositAndWithdrawHistory {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
