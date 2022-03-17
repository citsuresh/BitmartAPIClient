using System.Threading.Tasks;
using NUnit.Framework;

namespace BitmartApiClientTest {
    [TestFixture]
    public class ClientTests {
        private BitmartApiClient.Client _client;
        private string _key = ""; //Enter api key
        private string _secret = ""; //Enter api secret;
        private string _memo = "";//Enter api memo;
        [SetUp]
        public void Setup() {
            _client = new BitmartApiClient.Client(_key, _secret, _memo);
        }
        /*********************************** System Status Tests Start ***********************************/
        [Test]
        public void TestGetSystemTime() {
            Task.Run(async () => {
                var response = await _client.GetSystemTime();
                Assert.IsInstanceOf<BitmartApiClient.Models.SystemStatus.GetSystemTime.Response>(response);
            }).GetAwaiter().GetResult();
        }

        [Test]
        public void TestGetSystemServiceStatus() {
            Task.Run(async () => {
                var response = await _client.GetSystemServiceStatus();
                Assert.IsInstanceOf<BitmartApiClient.Models.SystemStatus.GetSystemServiceStatus.Response>(response);
            }).GetAwaiter().GetResult();
        }
        /*********************************** System Status Tests End ***********************************/

        /*********************************** Restful Public Market Data Tests Start ***********************************/
        [Test]
        public void TestGetCurrencyList() {
            Task.Run(async () => {
                var response = await _client.GetCurrencyList();
                Assert.IsInstanceOf<BitmartApiClient.Models.RestfulPublicMarketData.GetCurrencyList.Response>(response);
            }).GetAwaiter().GetResult();
        }

        [Test]
        public void TestGetListOfTradingPairs() {
            Task.Run(async () => {
                var response = await _client.GetListOfTradingPairs();
                Assert.IsInstanceOf<BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairs.Response>(response);
            }).GetAwaiter().GetResult();
        }

        [Test]
        public void TestGetListOfTradingPairDetails() {
            Task.Run(async () => {
                var response = await _client.GetListOfTradingPairDetails();
                Assert.IsInstanceOf<BitmartApiClient.Models.RestfulPublicMarketData.GetListOfTradingPairDetails.Response>(response);
            }).GetAwaiter().GetResult();
        }
        /*********************************** Restful Public Market Data Tests End ***********************************/
    }
}