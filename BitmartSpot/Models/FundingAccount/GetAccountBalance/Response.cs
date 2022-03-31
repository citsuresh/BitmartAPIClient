using Newtonsoft.Json;
namespace BitmartApiClient.Models.FundingAccount.GetAccountBalance
{
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
