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
    }
}