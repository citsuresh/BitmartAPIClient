namespace BitmartApiClient {
    public class Client {
        private const string BASE_URL = "https://api-cloud.bitmart.com";
        private string Key { get; }
        private string Secret { get; }
        private string Memo { get; }
        public Client(string aKey, string aSecret, string aMemo) {
            Key = aKey;
            Secret = aSecret;
            Memo = aMemo;
        }
        /*********************************** System Status Methods Start ***********************************/
        public async Task<Models.SystemStatus.GetSystemTime.Response> GetSystemTime() {
            var url = $"{BASE_URL}/system/time";
            var getSystemTimeRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.SystemStatus.GetSystemTime.Response>(getSystemTimeRequest);
            return response;
        }

        public async Task<Models.SystemStatus.GetSystemServiceStatus.Response> GetSystemServiceStatus() {
            var url = $"{BASE_URL}/system/service";
            var getSystemServiceStatusRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.SystemStatus.GetSystemServiceStatus.Response>(getSystemServiceStatusRequest);
            return response;
        }
        /*********************************** System Status Methods End ***********************************/

        /*********************************** Restful Public Market Data Methods Start ***********************************/
        public async Task<Models.RestfulPublicMarketData.GetCurrencyList.Response> GetCurrencyList() {
            var url = $"{BASE_URL}/spot/v1/currencies";
            var getCurrencyListRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetCurrencyList.Response>(getCurrencyListRequest);
            return response;
        }

        public async Task<Models.RestfulPublicMarketData.GetListOfTradingPairs.Response> GetListOfTradingPairs() {
            var url = $"{BASE_URL}/spot/v1/symbols";
            var getListOfTradingPairsRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetListOfTradingPairs.Response>(getListOfTradingPairsRequest);
            return response;
        }

        public async Task<Models.RestfulPublicMarketData.GetListOfTradingPairDetails.Response> GetListOfTradingPairDetails() {
            var url = $"{BASE_URL}/spot/v1/symbols/details";
            var getListOfTradingPairDetailsRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetListOfTradingPairDetails.Response>(getListOfTradingPairDetailsRequest);
            return response;
        }
        /*********************************** Restful Public Market Data Methods End ***********************************/
    }
}