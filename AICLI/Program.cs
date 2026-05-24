using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AICLI 
{
    public class Program
    { 
        static async Task Main(string[] args) 
        {
            if (args.Length == 0) 
            {
                Console.WriteLine("Usage: ai \"Your prompt here\"");
                return;
            }

            string? apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");
            if (string.IsNullOrEmpty(apiKey)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: GEMINI_API_KEY environment variable is not set.");
                return;
            }

            string userPrompt = string.Join(" ", args);
            string systemPrompt = "You are a strict Windows PowerShell assistant. Only respond with valid PowerShell commands. Do not provide explanations or any text other than the command itself.";

            using var client = new HttpClient();
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.5-flash:generateContent?key={apiKey}";

            var requestBody = new
            {
                system_instruction = new { parts = new[] { new { text = systemPrompt } } },
                contents = new[] { new { parts = new[] { new { text = userPrompt } } } }
            };

            string jsonRequest = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            try 
            {
                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string responseString = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(responseString);
                string generatedCommand = doc.RootElement
                    .GetProperty("candidates")[0]
                    .GetProperty("content")
                    .GetProperty("parts")[0]
                    .GetProperty("text")
                    .GetString() ?? string.Empty;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(generatedCommand);
            } 
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}