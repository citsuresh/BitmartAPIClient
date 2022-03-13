using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace BitmartApiClient {
    internal class Request {
        internal static readonly string UserAgent =
            $"{AssemblyVersionInformation.AssemblyProduct}/{AssemblyVersionInformation.AssemblyVersion} ({AssemblyVersionInformation.AssemblyTitle}; {AssemblyVersionInformation.AssemblyDescription})";

        public static WebRequest CreateRequestWithAgent(string aUrl, string aRequestMethod) {
            var request = CreateRequest(aUrl, aRequestMethod);
            request.Headers["User-Agent"] = UserAgent;
            request.Headers["Content-Length"] = "0";
            return request;
        }

        public static WebRequest CreateRequest(string aUrl, string aRequestMethod) {
            var request = WebRequest.Create(aUrl) as HttpWebRequest;
            Debug.Assert(request != null, nameof(request) + " != null");
            request.Method = aRequestMethod;
            request.Headers["Content-Type"] = "application/json";
            return request;
        }

        public static void AddHeader(WebRequest aRequest, string aHeaderName, string aHeaderValue) => aRequest.Headers[aHeaderName] = aHeaderValue;

        public static async Task<T> Get<T>(WebRequest aRequest) {
            try {
                string respbody;
                await using (var resp = (await aRequest.GetResponseAsync()).GetResponseStream()) {
                    var respR = new StreamReader(resp ?? throw new InvalidOperationException());
                    respbody = await respR.ReadToEndAsync();
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(respbody);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.Write($"Web request exception occurred in ${typeof(T)} exchange");
            }
            return default;
        }

        public static async Task<T> Post<T>(WebRequest aRequest, string aBody) {
            try {
                await using (var streamWriter = new StreamWriter(await aRequest.GetRequestStreamAsync())) {
                    await streamWriter.WriteAsync(aBody);
                }

                var httpResponse = (HttpWebResponse)await aRequest.GetResponseAsync();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream() ?? throw new InvalidOperationException())) {
                    var result = await streamReader.ReadToEndAsync();
                    return JsonSerializer.Deserialize<T>(result);
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.Write($"Web request exception occurred in ${typeof(T)} exchange");
                throw;
            }
        }

        public static async Task<T> Get<T>(WebRequest aRequest, string aStringToRemove) {
            try {
                string respbody;
                await using (var resp = (await aRequest.GetResponseAsync()).GetResponseStream()) {
                    var respR = new StreamReader(resp ?? throw new InvalidOperationException());
                    respbody = await respR.ReadToEndAsync();
                }
                return JsonSerializer.Deserialize<T>(respbody.Replace(aStringToRemove, ""));
            }
            catch {
                Console.Write($"Web request exception occurred in ${typeof(T)} exchange");
            }
            return default;
        }
    }
}
