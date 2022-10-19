using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace BitmartApiClient
{
    internal class Request
    {
        internal static readonly string UserAgent =
            $"{AssemblyVersionInformation.AssemblyProduct}/{AssemblyVersionInformation.AssemblyVersion} ({AssemblyVersionInformation.AssemblyTitle}; {AssemblyVersionInformation.AssemblyDescription})";

        public static WebRequest CreateRequestWithKey(string aUrl, string aKey, string aRequestMethod)
        {
            var request = CreateRequestWithAgent(aUrl, aRequestMethod);
            request.Headers["X-BM-KEY"] = aKey;
            return request;
        }

        public static WebRequest CreateRequestWithSignature(string aUrl, string aKey, string aSecret, string aMemo, string aBody, string aTime, string aRequestMethod)
        {
            var request = CreateRequestWithKey(aUrl, aKey, aRequestMethod);
            if (aBody == "")
                aBody = request.RequestUri.AbsolutePath;
            var signature = GenerateSignature(aTime, aSecret, aMemo, aBody);
            request.Headers["X-BM-SIGN"] = signature;
            request.Headers["X-BM-TIMESTAMP"] = aTime;
            return request;
        }

        public static WebRequest CreateRequestWithAgent(string aUrl, string aRequestMethod)
        {
            var request = CreateRequest(aUrl, aRequestMethod);
            request.Headers["User-Agent"] = UserAgent;
            return request;
        }

        public static WebRequest CreateRequest(string aUrl, string aRequestMethod)
        {
            var request = WebRequest.Create(aUrl) as HttpWebRequest;
            Debug.Assert(request != null, nameof(request) + " != null");
            request.Method = aRequestMethod;
            request.ContentType = "application/json; charset=utf-8";
            return request;
        }

        private static string GenerateSignature(string aTimestamp, string aSecret, string aMemo, string aBody) =>
            CreateSignature(aSecret, $"{aTimestamp}#{aMemo}#{aBody}");

        private static string CreateSignature(string aSecret, string aQueryString)
        {
            var keyBytes = Encoding.UTF8.GetBytes(aSecret);
            var queryStringBytes = Encoding.UTF8.GetBytes(aQueryString);
            var hmacsha256 = new HMACSHA256(keyBytes);
            var bytes = hmacsha256.ComputeHash(queryStringBytes);
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }

        public static void AddHeader(WebRequest aRequest, string aHeaderName, string aHeaderValue) => aRequest.Headers[aHeaderName] = aHeaderValue;

        public static T Get<T>(WebRequest aRequest)
        {
            try
            {
                string respbody;
                using (var resp = (aRequest.GetResponse()).GetResponseStream())
                {
                    var respStream = new StreamReader(resp ?? throw new InvalidOperationException());
                    respbody = respStream.ReadToEnd();
                }
                var response = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(respbody);
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write($"Web request exception occurred in ${typeof(T)} exchange");
            }
            return default(T);
        }

        public static async Task<T> GetAsync<T>(WebRequest aRequest)
        {
            try
            {
                string respbody;
                await using (var resp = (await aRequest.GetResponseAsync()).GetResponseStream())
                {
                    var respR = new StreamReader(resp ?? throw new InvalidOperationException());
                    respbody = await respR.ReadToEndAsync();
                }
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(respbody);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write($"Web request exception occurred in ${typeof(T)} exchange");
            }
            return default;
        }

        public static async Task<T> Post<T>(WebRequest aRequest, string aBody)
        {
            try
            {
                await using (var streamWriter = new StreamWriter(await aRequest.GetRequestStreamAsync()))
                {
                    await streamWriter.WriteAsync(aBody);
                }

                var httpResponse = (HttpWebResponse)await aRequest.GetResponseAsync();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream() ?? throw new InvalidOperationException()))
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    };

                    var result = await streamReader.ReadToEndAsync();
                    return JsonSerializer.Deserialize<T>(result, options);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write($"Web request exception occurred in ${typeof(T)} exchange");
                throw;
            }
        }
    }
}
