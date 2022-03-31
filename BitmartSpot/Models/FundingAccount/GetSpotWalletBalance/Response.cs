using Newtonsoft.Json;
namespace BitmartApiClient.Models.FundingAccount.GetSpotWalletBalance {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
