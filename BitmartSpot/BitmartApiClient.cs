using BitmartApiClient.Utils;
using System.Threading.Tasks;

namespace BitmartApiClient {
    public class BitmartApiClient : IBitmartApiClient
    {
        private const string BASE_URL = "https://api-cloud.bitmart.com";
        private string Key { get; }
        private string Secret { get; }
        private string Memo { get; }
        public BitmartApiClient(string aKey, string aSecret, string aMemo) {
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

        /*********************************** Funding Account Methods Start ***********************************/
        public async Task<Models.FundingAccount.GetAccountBalance.Response> GetAccountBalance() {
            var url = $"{BASE_URL}/account/v1/wallet?account_type=1";
            var getAccountBalanceRequest = Request.CreateRequestWithKey(url, Key, RequestMethods.GET);
            var response = await Request.Get<Models.FundingAccount.GetAccountBalance.Response>(getAccountBalanceRequest);
            return response;
        }

        public async Task<Models.FundingAccount.GetCurrencies.Response> GetCurrencies() {
            var url = $"{BASE_URL}/account/v1/currencies";
            var getCurrenciesRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.FundingAccount.GetCurrencies.Response>(getCurrenciesRequest);
            return response;
        }

        public async Task<Models.FundingAccount.GetSpotWalletBalance.Response> GetSpotWalletBalance() {
            var url = $"{BASE_URL}/spot/v1/wallet";
            var getSpotWalletBalanceRequest = Request.CreateRequestWithKey(url, Key, RequestMethods.GET);
            var response = await Request.Get<Models.FundingAccount.GetSpotWalletBalance.Response>(getSpotWalletBalanceRequest);
            return response;
        }

        public async Task<Models.FundingAccount.DepositAddress.Response> DepositAddress(string aCurrency) {
            var url = $"{BASE_URL}/account/v1/deposit/address?currency={aCurrency}";
            var depositAddressRequest = Request.CreateRequestWithKey(url, Key, RequestMethods.GET);
            var response = await Request.Get<Models.FundingAccount.DepositAddress.Response>(depositAddressRequest);
            return response;
        }

        public async Task<Models.FundingAccount.GetDepositAndWithdrawHistory.Response> GetDepositAndWithdrawHistory(int aNumberOfRecentRecords, string anOperationType, string aCurrency = "") {
            var url = $"{BASE_URL}/account/v2/deposit-withdraw/history?N={aNumberOfRecentRecords}&operation_type={anOperationType}&currency={aCurrency}";
            var getDepositAndWithdrawHistoryRequest = Request.CreateRequestWithKey(url, Key, RequestMethods.GET);
            var response = await Request.Get<Models.FundingAccount.GetDepositAndWithdrawHistory.Response>(getDepositAndWithdrawHistoryRequest);
            return response;
        }

        public async Task<Models.FundingAccount.GetADepositOrWithdrawDetail.Response> GetADepositOrWithdrawDetail(string anId) {
            var url = $"{BASE_URL}/account/v1/deposit-withdraw/detail?id={anId}";
            var getADepositOrWithdrawDetailRequest = Request.CreateRequestWithKey(url, Key, RequestMethods.GET);
            var response = await Request.Get<Models.FundingAccount.GetADepositOrWithdrawDetail.Response>(getADepositOrWithdrawDetailRequest);
            return response;
        }
        /*********************************** Funding Account Methods End ***********************************/

        /*********************************** Transaction Order Methods Start ***********************************/
        public async Task<Models.TransactionOrder.GetUserOrderHistory.Response> GetUserOrderHistory(string aSymbol, int aNumberOfRecentRecords, Models.TransactionOrder.GetUserOrderHistory.Status aStatus) {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v2/orders?symbol={aSymbol}&status={(int)aStatus}&N={aNumberOfRecentRecords}";
            var getUserOrderHistoryRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, "", time.Data.ServerTime.ToString(), RequestMethods.GET);
            var response = await Request.Get<Models.TransactionOrder.GetUserOrderHistory.Response>(getUserOrderHistoryRequest);
            return response;
        }

        public async Task<Models.TransactionOrder.GetUserTradeHistory.Response> GetUserTradeHistory(string aSymbol, int anOffset = 1, int aLimit = 10, string anOrderId = "") {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v1/trades?symbol={aSymbol}&offset={anOffset}&limit={aLimit}";
            if (anOrderId != "") url += $"&order_id={anOrderId}";
            var getUserTradeHistoryRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, "", time.Data.ServerTime.ToString(), RequestMethods.GET);
            var response = await Request.Get<Models.TransactionOrder.GetUserTradeHistory.Response>(getUserTradeHistoryRequest);
            return response;
        }

        public async Task<Models.TransactionOrder.GetOrderDetail.Response> GetOrderDetail(string anOrderId, string aClientOrderId = "") {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v1/order_detail?order_id={anOrderId}";
            if (aClientOrderId != "") url += $"&clientOrderId={aClientOrderId}";
            var getOrderDetailRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, "", time.Data.ServerTime.ToString(), RequestMethods.GET);
            var response = await Request.Get<Models.TransactionOrder.GetOrderDetail.Response>(getOrderDetailRequest);
            return response;
        }

        public async Task<Models.Model> CancelAllOrders(string aSymbol, Models.TransactionOrder.Side aSide) {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v1/cancel_orders";
            var body = Models.TransactionOrder.CancelAllOrders.Request.New(aSymbol, aSide.ToString().ToLower()).ToJsonString();
            var cancelAllOrdersRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, body, time.Data.ServerTime.ToString(), RequestMethods.POST);
            var response = await Request.Post<Models.Model>(cancelAllOrdersRequest, body);
            return response;
        }

        public async Task<Models.TransactionOrder.CancelOrder.Response> CancelOrder(int anOrderId) {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v2/cancel_order";
            var body = Models.TransactionOrder.CancelOrder.Request.New(anOrderId).ToJsonString();
            var cancelOrderRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, body, time.Data.ServerTime.ToString(), RequestMethods.POST);
            var response = await Request.Post<Models.TransactionOrder.CancelOrder.Response>(cancelOrderRequest, body);
            return response;
        }

        public async Task<Models.TransactionOrder.PlaceOrder.Response> PlaceOrder(string aSymbol, Models.TransactionOrder.Side aSide, Models.TransactionOrder.OrderType anOrderType, string aSize, string aPrice, string aNotional) {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v1/submit_order";
            var body = Models.TransactionOrder.PlaceOrder.Request.New(aSymbol, aSide.ToString().ToLower(), anOrderType.ToString().ToLower(), aSize, aPrice, aNotional).ToJsonString();
            var placeOrderRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, body, time.Data.ServerTime.ToString(), RequestMethods.POST);
            var response = await Request.Post<Models.TransactionOrder.PlaceOrder.Response>(placeOrderRequest, body);
            return response;
        }

        public async Task<Models.TransactionOrder.BatchOrder.Response> BatchOrder(List<Models.TransactionOrder.BatchOrder.OrderParam> someOrderParams) {
            var time = await GetSystemTime();
            var url = $"{BASE_URL}/spot/v1/batch_orders";
            var body = Models.TransactionOrder.BatchOrder.Request.New(someOrderParams).ToJsonString();
            var batchOrdersRequest = Request.CreateRequestWithSignature(url, Key, Secret, Memo, body, time.Data.ServerTime.ToString(), RequestMethods.POST);
            var response = await Request.Post<Models.TransactionOrder.BatchOrder.Response>(batchOrdersRequest, body);
            return response;
        }
        /*********************************** TransactionOrder Methods End ***********************************/


    }
}