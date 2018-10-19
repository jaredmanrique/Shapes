using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Helpers
{
    public class ClientHelper
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public Task<HttpResponseMessage> PostAsyncAsJson<T>(string URL,T data)
        {
            string ApiBaseUrl = ConfigurationManager.AppSettings.GetValues("ApiBaseUrl")[0];

            var content = JsonConvert.SerializeObject(data);
            var encodedContent = System.Text.Encoding.UTF8.GetBytes(content);
            var bytesContent = new ByteArrayContent(encodedContent);
            bytesContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return httpClient.PostAsync($"{ApiBaseUrl}{URL}", bytesContent);
        }
    }
}
