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

            new Animal(1,"Milo", "Terranoba", 7, "macho", "Perro", new Persona("45353230", "Victoria", "Arias")),
            new Animal(2,"Molly", "kho manee", 5, "Hembra", "gato ",new Persona("46695", "mica", "colman")),
        };

        [HttpGet]
        public List<Animal> ConsultarAnimal()
        {
            return ListaAnimales;
        }

        [HttpPost]
        public int CrearAnimal(Animal animal)
        {
            ListaAnimales.Add(animal);
            return animal.id;
        }

        [HttpPut("{Id}")]
        public ActionResult ActualizarAnimal(int Id, Animal animal)
        {
            var AnimalActualizar = ListaAnimales.Find(x => x.id == Id);

            if (AnimalActualizar == null)
            {
                return NotFound();
            }

            AnimalActualizar.id = animal.id;
            AnimalActualizar.nombreAnimal = animal.nombreAnimal;
            AnimalActualizar.dueño = animal.dueño;

            return Ok();
        }
        [HttpGet("{Id}")]
        public ActionResult ConsultarAnimal(int Id)
        {
            var animal = ListaAnimales.Find(x => x.id == Id);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{Id}")]
        public ActionResult BorrarAnimal(int Id)
        {
            var animalBorrar = ListaAnimales.Find(x => x.id == Id);
            if (animalBorrar == null)
            {
                return NotFound();
            }
            ListaAnimales.Remove(animalBorrar);

            return Ok();
        }
    }
}
