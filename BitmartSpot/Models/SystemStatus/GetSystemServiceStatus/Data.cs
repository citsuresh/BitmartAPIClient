using Newtonsoft.Json;

namespace BitmartApiClient.Models.SystemStatus.GetSystemServiceStatus {
    public class Data {
        [JsonProperty("service")]
        public List<Service> Service { get; set; }
    }
}
