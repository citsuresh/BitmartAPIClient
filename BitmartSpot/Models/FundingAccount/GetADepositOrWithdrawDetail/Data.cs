using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetADepositOrWithdrawDetail
{
    public class Data {
        [JsonProperty("records")]
        public List<Record> Records { get; set; }
    }
}
