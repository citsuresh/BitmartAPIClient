using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetDepositAndWithdrawHistory
{
    public class Data {
        [JsonProperty("records")]
        public List<Record> Records { get; set; }
    }
}
