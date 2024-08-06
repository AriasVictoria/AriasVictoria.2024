using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TrabajoPracticoApi.Model;

class Program
{
    static async Task Main()
    {
        var urlA = "http://localhost:5146/api/animal";
        var urlH = "http://localhost:5146/api/historial";
        var urlP = "http://localhost:5146/api/persona";

        JsonSerializerOptions opciones = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        
        //GETANIMAL
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(urlA);
            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsStringAsync();
                var animales = JsonSerializer.Deserialize<List<Animal>>(contenido, opciones);
                foreach (var animal in animales)
                {
                    Console.WriteLine($"{animal.id} {animal.nombreAnimal} {animal.edad} {animal.raza} {animal.tipoAnimal} {animal.sexo} {animal.dueño}");
                }
            }
            else { Console.WriteLine("no hay animales registrados"); }
        }

        //POSTANIMAL
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PostAsJsonAsync(urlH, new Animal { id= 1, nombreAnimal= "Milo", raza= "Terranoba", edad= 7, sexo= "macho", tipoAnimal= "Perro", dueño= "4553230" });
            if (response.IsSuccessStatusCode) { Console.WriteLine("Animal agregado"); }
            else { Console.WriteLine("error al guardar los datos"); }
        }

        //PUTANIMAL
        var urlA2 = "http://localhost:5146/api/animal/1";
        int animalId = 1;  
        var url = $"{urlA2}/{animalId}"; 

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PutAsJsonAsync(url, new Animal { id = 1, nombreAnimal = "Milo", raza = "Terranoba", edad = 7, sexo = "macho", tipoAnimal = "Perro", dueño = "4553230" }); 

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Animal actualizado");
            }
            else
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //DELETEANIMAL
        var urlA3 = "http://localhost:5146/api/animal/3";
        int animalId1 = 3;  
        var url3 = $"{urlA3}/{animalId1}"; 
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.DeleteAsync(url); 

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Animal eliminado");
            }
            else
            {
                Console.WriteLine("Error al eliminar los datos");
            }
        }

        //GETHISTORIAL
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(urlH);
            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsStringAsync();
                var historiales = JsonSerializer.Deserialize<List<Historial>>(contenido, opciones);
                foreach (var historial in historiales)
                {
                    Console.WriteLine($"{historial.id} {historial.animal} {historial.fecha_consulta} {historial.motivo_consulta} {historial.tratamiento} {historial.medicamento}");
                }
            }
            else { Console.WriteLine("no hay historiales registrados"); }
        }

        //POSTHISTORIAL
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PostAsJsonAsync(urlH, new Historial(1, (new Animal(1, "Milo", "Terranoba", 7, "macho", "Perro", "45353230")),
                DateTime.Now, "vacunacion", "colocacion de infectable", "vacuna contra ravia"));
            if (response.IsSuccessStatusCode) { Console.WriteLine("Historial agregado"); }
            else { Console.WriteLine("error al guardar los datos"); }
        }

        //PUTHISTORIAL
        var urlH2 = "http://localhost:5146/api/historial/2";
        int id_Historial = 2;  
        var url2 = $"{urlH2}/{id_Historial}";

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PutAsJsonAsync(url, new Historial(1, (new Animal(1, "Milo", "Terranoba", 7, "macho", "Perro", "45353230")),
                DateTime.Now, "vacunacion", "colocacion de infectable", "vacuna contra ravia"));

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Historial actualizado");
            }
            else
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //DELETEHISTORIAL
        var urlH3 = "http://localhost:5146/api/historial/2";
        int id_Historial1 = 2;
        var url4 = $"{urlA3}/{id_Historial1}";
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Historial eliminado");
            }
            else
            {
                Console.WriteLine("Error al eliminar los datos");
            }
        }

        //GETPERSONA
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(urlP);
            if (response.IsSuccessStatusCode)
            {
                var contenido = await response.Content.ReadAsStringAsync();
                var personas = JsonSerializer.Deserialize<List<Persona>>(contenido, opciones);
                foreach (var persona in personas)
                {
                    Console.WriteLine($"{persona.dni} {persona.Nombre} {persona.Apellido} {persona.Telefono}");
                }
            }
            else { Console.WriteLine("no hay personas registrados"); }
        }

        //POSTPERSONA
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PostAsJsonAsync(urlP, new Persona { dni= "45353230", Nombre= "Victoria", Apellido= "Arias", Telefono= "3493525636" });
            if (response.IsSuccessStatusCode) { Console.WriteLine("Persona agregada"); }
            else { Console.WriteLine("error al guardar los datos"); }
        }

        //PUTPERSONA
        var urlP2 = "http://localhost:5146/api/persona/1";
        int personaId = 1;
        var url5 = $"{urlP2}/{personaId}";

        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.PutAsJsonAsync(url, new Persona { dni = "45353230", Nombre = "Victoria", Apellido = "Arias", Telefono = "3493525636" });

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Persona actualizado");
            }
            else
            {
                Console.WriteLine("Error al actualizar los datos");
            }
        }

        //DELETEPERSONA
        var urlP3 = "http://localhost:5146/api/persona/2";
        int personaId1 = 2;
        var url6 = $"{urlA3}/{personaId1}";
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.DeleteAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Persona eliminado");
            }
            else
            {
                Console.WriteLine("Error al eliminar los datos");
            }
        }
    }
}
