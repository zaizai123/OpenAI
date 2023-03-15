using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace OpenAILibrary
{
    public class OpenAILib
    {
        string APIKey;
        public OpenAILib()
        {
            APIKey = new GetSecret().GetSecretByKey("ApiKey");
        }

        public string OpenAIPrompt(string question, float temperature, string model)
        {
            string ret = "";
            string url = @"https://api.openai.com/v1/completions";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + APIKey);

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var requestBody = new Dictionary<string, object>()
                {
                    { "model", model },
                    { "prompt", question },
                    { "temperature", temperature },
                    { "top_p", 1 },
                    { "frequency_penalty", 0 },
                    { "presence_penalty", 0 },
                    { "max_tokens", 2048 },
                    { "stop", "[\n]"}
                };
                //string json = "{\"model\": \"text-davinci-003\", \"prompt\": \"Hello\", \"temperature\": 0, \"max_tokens\": 7}";
                string json = JsonConvert.SerializeObject(requestBody);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8, true, 4096))
                {
                    ret = streamReader.ReadToEnd();
                }
                var textCompletion = JsonConvert.DeserializeObject<TextCompletion>(ret);
                return textCompletion.Choices.First().Text;
            }
            catch
            {
                return "OOPS! Try a different text.";
            }
        }

        public string CreateImage(string prompt)
        {
            string url = @"https://api.openai.com/v1/images/generations";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + APIKey);

            string textCompletion = "";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var requestBody = new Dictionary<string, object>()
                {
                    { "prompt", prompt },
                    { "n", 1 },
                    { "size", "1024x1024" }
                };
                string json = JsonConvert.SerializeObject(requestBody);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    textCompletion = ((ImageData)JsonConvert.DeserializeObject<ImageData>(result)).Data[0].Url;
                }
                Process photoViewer = new Process();
                photoViewer.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                photoViewer.StartInfo.Arguments = textCompletion;
                photoViewer.Start();
                return textCompletion;
            }
            catch
            {
                return "OOPS! Try a different image text.";
            }
        }


        private string GetUrlWithParameter(string url, Dictionary<string, string> parameters)
        {
            return $"{url}?{string.Join("&", parameters.Select(kvp => $"{kvp.Key}={kvp.Value}"))}";
        }

        public class TextCompletion
        {
            public string Id { get; set; }
            public string Object { get; set; }
            public int Created { get; set; }
            public string Model { get; set; }
            public List<Choice> Choices { get; set; }
            public Usage Usage { get; set; }
        }

        public class Choice
        {
            public string Text { get; set; }
            public int Index { get; set; }
            public object Logprobs { get; set; }
            public string Finish_Reason { get; set; }
        }

        public class Usage
        {
            public int Prompt_Tokens { get; set; }
            public int Completion_Tokens { get; set; }
            public int Total_Tokens { get; set; }
        }

        public class ImageData
        {
            public int Created { get; set; }
            public List<DataItem> Data { get; set; }
        }

        public class DataItem
        {
            public string Url { get; set; }
        }
    }
}
