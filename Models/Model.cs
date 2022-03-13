using Newtonsoft.Json;

namespace BitmartApiClient.Models {
    public class Model<T> {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("trace")]
        public string Trace { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
