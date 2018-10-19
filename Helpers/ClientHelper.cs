using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Helpers
{
    public class ClientHelper
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public Task<HttpResponseMessage> PostAsyncAsJson()
        {
            var content = JsonConvert.SerializeObject(shape);
            var encodedContent = System.Text.Encoding.UTF8.GetBytes(content);
            var bytesContent = new ByteArrayContent(encodedContent);
            bytesContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            return httpClient.PostAsync("Calculate/Determine", bytesContent);
        }
    }
}
