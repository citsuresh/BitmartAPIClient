using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetCurrencies
{
    public class Data {
        [JsonProperty("currencies")]
        public List<Currency> Currencies { get; set; }
    }
}
