using BitmartApiClient.Models;
using BitmartApiClient.Models.TransactionOrder;
using BitmartApiClient.Models.TransactionOrder.BatchOrder;
using BitmartApiClient.Models.TransactionOrder.GetUserOrderHistory;

namespace BitmartApiClient
{
    public interface IBitmartApiClient
    {
        Task<Models.TransactionOrder.BatchOrder.Response> BatchOrder(List<OrderParam> someOrderParams);
        Task<Model> CancelAllOrders(string aSymbol, Side aSide);
        Task<Models.TransactionOrder.CancelOrder.Response> CancelOrder(long anOrderId);
        Task<Models.FundingAccount.DepositAddress.Response> DepositAddress(string aCurrency);
        Task<Models.FundingAccount.GetAccountBalance.Response> GetAccountBalance();
        Task<Models.FundingAccount.GetADepositOrWithdrawDetail.Response> GetADepositOrWithdrawDetail(string anId);
        Task<Models.FundingAccount.GetCurrencies.Response> GetCurrencies();
        Task<Models.RestfulPublicMarketData.GetCurrencyList.Response> GetCurrencyList();
        Task<Models.FundingAccount.GetDepositAndWithdrawHistory.Response> GetDepositAndWithdrawHistory(int aNumberOfRecentRecords, string anOperationType, string aCurrency = "");
        Task<Models.RestfulPublicMarketData.GetDepth.Response> GetDepth(string aSymbol, int aPrecision);
        Task<Models.RestfulPublicMarketData.GetDepth.Response> GetOrderBook(string aSymbol, int limit);
        Task<Models.RestfulPublicMarketData.GetKLine.Response> GetKLine(string aSymbol, long aFromTimestamp, long aToTimestamp, long aStep = 1);
        Task<Models.RestfulPublicMarketData.GetKLineStep.Response> GetKLineStep(string aSymbol);
        Task<Models.RestfulPublicMarketData.GetListOfTradingPairDetails.Response> GetListOfTradingPairDetails();
        Task<Models.RestfulPublicMarketData.GetListOfTradingPairs.Response> GetListOfTradingPairs();
        Task<Models.TransactionOrder.GetOrders.Response> GetActiveOrders(string aSymbol, int aLimit = 10);
        Task<Models.TransactionOrder.GetOrders.Response> GetCompletedOrders(string aSymbol, int aLimit = 10);
        Task<Models.TransactionOrder.GetOrderDetail.Response> GetOrderDetail(string anOrderId, string aClientOrderId = "");
        Task<Models.RestfulPublicMarketData.GetRecentTrades.Response> GetMyRecentTrades(string aSymbol);
        Task<Models.RestfulPublicMarketData.GetRecentTrades.Response> GetMyRecentTrades();
        Task<Models.RestfulPublicMarketData.GetRecentTrades.Response> GetRecentTrades(string aSymbol);
        Task<Models.FundingAccount.GetSpotWalletBalance.Response> GetSpotWalletBalance();
        Task<Models.SystemStatus.GetSystemServiceStatus.Response> GetSystemServiceStatus();
        Task<Models.SystemStatus.GetSystemTime.Response> GetSystemTime();
        Task<Models.RestfulPublicMarketData.GetTicker.Response> GetTickers();
        Task<Models.RestfulPublicMarketData.GetTicker.Response> GetTicker(string aSymbol);
        Task<Models.TransactionOrder.GetUserOrderHistory.Response> GetUserOrderHistory(string aSymbol, int aNumberOfRecentRecords, Status aStatus);
        Task<Models.TransactionOrder.GetUserTradeHistory.Response> GetUserTradeHistory(string aSymbol, int anOffset = 1, int aLimit = 10, string anOrderId = "");
        Task<Models.TransactionOrder.PlaceOrder.Response> PlaceOrder(string aSymbol, Side aSide, OrderType anOrderType, string aSize, string aPrice, string aNotional);
        Task<Models.RestfulPublicMarketData.GetTradeFee.Response> GetTradeFee(string baseCurrency, string quoteCurrency);
    }
}