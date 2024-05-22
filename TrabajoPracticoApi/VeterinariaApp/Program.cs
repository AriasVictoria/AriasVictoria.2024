using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        var apiUrl = "http://localhost:5146/api/persona/"; // URL de tu API
        var persona = new HttpClient { BaseAddress = new Uri(apiUrl) };
        persona.DefaultRequestHeaders.Accept.Clear();
        persona.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        var response = await persona.GetAsync("http://localhost:5146/api/persona");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Respuesta de la API: {content}");
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
        }
    }
}
