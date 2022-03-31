using Newtonsoft.Json;
namespace BitmartApiClient.Models.FundingAccount.DepositAddress
{
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
