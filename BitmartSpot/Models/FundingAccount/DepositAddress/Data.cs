using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.DepositAddress
{
    public class Data {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("chain")]
        public string Chain { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address_memo")]
        public string AddressMemo { get; set; }
    }
}
