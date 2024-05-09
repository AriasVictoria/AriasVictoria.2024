using Microsoft.AspNetCore.Mvc;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Controllers
{
    [ApiController]
    [Route("api/animal")]
    public class AnimalControllers : ControllerBase
    {
        static List<Animal> ListaAnimales = new List<Animal>()
        {
            new Animal("Milo", "Terranoba", 7, "macho", "Perro","Micaela colman"),
            new Animal("Molly", "kho manee", 5, "Hembra", "gato ","Micaela colman"),
        };

        [HttpGet]
        public List<Animal> ConsultarAnimal()
        {
            return ListaAnimales;
        }

        [HttpPost]
        public string ConsultarAnimal(Animal animal)
        {
            ListaAnimales.Add(animal);
            return animal.nombreAnimal;
        }
        [HttpPut("{Nombre}")]
        public ActionResult ActualizarAnimal(string nombre, Animal animal)
        {
            var ActualizarAnimal = ListaAnimales.Find(x => x.nombreAnimal == nombre);

            if (ActualizarAnimal == null)
            {
                return NotFound();
            }

            ActualizarAnimal.dueño = animal.dueño;
            ActualizarAnimal.edad = animal.edad;

            return Ok();
        }
        [HttpGet("{nombre}")]
        public ActionResult ConsultarAnimal(string nombre)
        {
            var animal = ListaAnimales.Find(x => x.nombreAnimal == nombre);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete("{nombre}")]
        public ActionResult BorrarAnimal(string nombre)
        {
            var animalBorrar = ListaAnimales.Find(x => x.nombreAnimal == nombre);
            if (animalBorrar == null)
            {
                return NotFound();
            }
            ListaAnimales.Remove(animalBorrar);

            return Ok();
        }
    }
}
