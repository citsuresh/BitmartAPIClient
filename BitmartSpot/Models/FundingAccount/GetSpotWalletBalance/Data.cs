﻿using Newtonsoft.Json;

namespace BitmartApiClient.Models.FundingAccount.GetSpotWalletBalance
{
    public class Data {
        [JsonProperty("wallet")]
        public List<Wallet> Wallet { get; set; }
    }
}
