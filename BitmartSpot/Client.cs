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
            var timeRequest = Request.CreateRequestWithAgent(url, RequestMethods.GET);
            var response = await Request.Get<Models.SystemStatus.GetSystemTime.Response>(timeRequest);
            return response;
        }
    }
}