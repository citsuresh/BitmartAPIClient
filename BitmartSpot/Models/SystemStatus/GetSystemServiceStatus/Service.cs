using Newtonsoft.Json;
namespace BitmartApiClient.Models.SystemStatus.GetSystemServiceStatus {
    public class Service {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("service_type")]
        public string ServiceType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_time")]
        public object StartTime { get; set; }

        [JsonProperty("end_time")]
        public object EndTime { get; set; }
    }
}
