using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetDepositAndWithdrawHistory {
    public class Record {
        [JsonProperty("withdraw_id")]
        public string WithdrawId { get; set; }

        [JsonProperty("deposit_id")]
        public string DepositId { get; set; }

        [JsonProperty("operation_type")]
        public string OperationType { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("apply_time")]
        public long ApplyTime { get; set; }

        [JsonProperty("arrival_amount")]
        public string ArrivalAmount { get; set; }

        [JsonProperty("fee")]
        public string Fee { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address_memo")]
        public string AddressMemo { get; set; }

        [JsonProperty("tx_id")]
        public string TxId { get; set; }
    }
}
