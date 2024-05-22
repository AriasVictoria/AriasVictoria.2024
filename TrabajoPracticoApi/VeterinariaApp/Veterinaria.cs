using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaApp
{
    public class Veterinaria
    {
        static async Task Main()
        {
            var apiUrl = "https://api.example.com/"; // URL de tu API
            var client = new HttpClient { BaseAddress = new Uri(apiUrl) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // Llama al método GET
            var response = await client.GetAsync("ruta-de-tu-endpoint");
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
}
