using Newtonsoft.Json;

namespace BitmartApiClient.Models {
    public class Model {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("trace")]
        public string Trace { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
