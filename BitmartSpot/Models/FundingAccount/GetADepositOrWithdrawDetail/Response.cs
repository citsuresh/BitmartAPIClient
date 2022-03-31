using Newtonsoft.Json;
namespace BitmartApiClient.Models.FundingAccount.GetADepositOrWithdrawDetail {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
