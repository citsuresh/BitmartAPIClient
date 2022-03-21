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

        public async Task<Models.RestfulPublicMarketData.GetTicker.Response> GetTicker(string aSymbol) {
            var url = $"{BASE_URL}/spot/v1/ticker?symbol={aSymbol}";
            var getTickerRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetTicker.Response>(getTickerRequest);
            return response;
        }

        public async Task<Models.RestfulPublicMarketData.GetKLineStep.Response> GetKLineStep(string aSymbol) {
            var url = $"{BASE_URL}/spot/v1/steps?symbol={aSymbol}";
            var getKLineStepRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetKLineStep.Response>(getKLineStepRequest);
            return response;
        }

        public async Task<Models.RestfulPublicMarketData.GetKLine.Response> GetKLine(string aSymbol, long aFromTimestamp, long aToTimestamp, long aStep = 1) {
            var url = $"{BASE_URL}/spot/v1/symbols/kline?symbol={aSymbol}&step={aStep}&from={aFromTimestamp}&to={aToTimestamp}";
            var getKLineRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetKLine.Response>(getKLineRequest);
            return response;
        }

        public async Task<Models.RestfulPublicMarketData.GetDepth.Response> GetDepth(string aSymbol, int aPrecision) {
            var url = $"{BASE_URL}/spot/v1/symbols/book?symbol={aSymbol}&precision={aPrecision}";
            var getDepthRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetDepth.Response>(getDepthRequest);
            return response;
        }

        public async Task<Models.RestfulPublicMarketData.GetRecentTrades.Response> GetRecentTrades(string aSymbol) {
            var url = $"{BASE_URL}/spot/v1/symbols/trades?symbol={aSymbol}";
            var getRecentTradesRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.RestfulPublicMarketData.GetRecentTrades.Response>(getRecentTradesRequest);
            return response;
        }
        /*********************************** Restful Public Market Data Methods End ***********************************/
    }
}