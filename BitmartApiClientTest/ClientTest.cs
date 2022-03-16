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
    }
}