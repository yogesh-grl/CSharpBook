using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string apiKey = "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"; // Replace with your API key
        string apiUrl = "https://api.openai.com/v1/chat/completions"; // Example API endpoint

        HttpClient httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        string prompt = "Translate the following English text to French: 'Hello, world.'";
        int maxTokens = 50; // Adjust as needed

        var requestData = new
        {
            prompt = prompt,
            max_tokens = maxTokens
        };

        var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

        var response = await httpClient.PostAsync(apiUrl, content);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
        else
        {
            Console.WriteLine($"HTTP Error: {response.StatusCode}");
        }
    }
}
