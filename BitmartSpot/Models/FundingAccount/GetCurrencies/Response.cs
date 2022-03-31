using Newtonsoft.Json;
namespace BitmartApiClient.Models.FundingAccount.GetCurrencies
{
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
