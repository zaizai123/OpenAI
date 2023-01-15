using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace OpenAILibrary
{
    public class OpenAILib
    {
        string APIKey;
        public OpenAILib()
        {
            APIKey = new GetSecret().GetSecretByKey("ApiKey");
        }

        public async Task<string> OpenAIPrompt(string question)
        {
            string curl = @"https://api.openai.com/v1/completions";
            var reqBody = new Dictionary<string, string>{
                { "model", "text-davinci-003" },
                { "prompt", question },
                { "temperature", "0" },
                { "max_tokens", "100" },
                { "top_p", "1" },
                { "stop", "[\n]" },
                { "frequency_penalty", "0.0" },
                { "presence_penalty", "0.0" }
            };
            var reqBodyStr = JsonConvert.SerializeObject(reqBody);
            var content = new StringContent(reqBodyStr, Encoding.UTF8, "application/json");
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", APIKey);
            HttpResponseMessage resp = await client.PostAsync(curl, content);
            return "";
        }

        private string GetUrlWithParameter(string url, Dictionary<string, string> parameters)
        {
            return $"{url}?{string.Join("&", parameters.Select(kvp => $"{kvp.Key}={kvp.Value}"))}";
        }
    }
}
