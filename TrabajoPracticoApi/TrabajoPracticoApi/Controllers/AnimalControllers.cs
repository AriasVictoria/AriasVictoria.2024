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
        [HttpPut("{id}")]
        public ActionResult ActualizarAnimal(Animal animal)
        {
            var AnimalActualizar = ListaAnimales.Find(x => x.id == animal.id);

            if (AnimalActualizar == null)
            {
                return NotFound();
            }
            AnimalActualizar.nombreAnimal = animal.nombreAnimal;
            AnimalActualizar.dueño = animal.dueño;

            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult ConsultarAnimal(int Id)
        {
            var animal = ListaAnimales.Find(x => x.id == Id);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok(animal);
        }

        [HttpDelete("{id}")]
        public ActionResult BorrarAnimal(int id)
        {
            var animalBorrar = ListaAnimales.Find(x => x.id == id);
            if (animalBorrar == null)
            {
                return NotFound();
            }
            ListaAnimales.Remove(animalBorrar);

            return Ok();
        }
    }
}
