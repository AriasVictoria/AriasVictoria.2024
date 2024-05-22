using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrabajoPracticoApi.DtoAnimal;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Controllers
{
    [ApiController]
    [Route("api/animal")]
    public class AnimalControllers : ControllerBase  
    {
        static List<Animal> ListaAnimales = new List<Animal>()
        {

            new Animal(1,"Milo", "Terranoba", 7, "macho", "Perro", "4553230"),
            new Animal(2,"Molly", "kho manee", 5, "Hembra", "gato", "45342888"),
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
            var Actuazaliranimal = ListaAnimales.Find(x => x.id == animal.id);

            if (Actuazaliranimal == null)
            {
                return NotFound();
            }
            Actuazaliranimal.nombreAnimal = animal.nombreAnimal;
            Actuazaliranimal.edad = animal.edad;
            Actuazaliranimal.dueño = animal.dueño;

            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult ConsultarAnimal(int id)
        {
            var animal = ListaAnimales.Find(x => x.id == id);
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
