using Microsoft.AspNetCore.Mvc;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Controllers
{
    [ApiController]
    [Route("api/persona")]
    public class PersonaControllers : ControllerBase
    {
        static List<Persona> ListPersona = new List<Persona>()
        {
            new Persona("45353230", "Victoria", "Arias", "3493525636"),
            new Persona("45342888", "Maria Lara", "Morelli", "3493596230"),
        };

        [HttpGet]
        public List<Persona> ConsultarPersoona()
        {
            return ListPersona;
        }

        [HttpPost]
        public string CrearPersona(Persona persona)
        {
            ListPersona.Add(persona);
            return persona.dni;
        }
        [HttpPut("{dni}")]
        public ActionResult ActualizarPersona(Persona persona)
        {
            var ActualizarPersona = ListPersona.Find(x => x.dni == persona.dni);

            if (ActualizarPersona == null)
            {
                return NotFound();
            }

            ActualizarPersona.Nombre = persona.Nombre;
            ActualizarPersona.Apellido = persona.Apellido;

            return Ok();
        }
        [HttpGet("{dni}")]
        public ActionResult ConsultarPersona(string dni)
        {
            var persona = ListPersona.Find(x => x.dni == dni);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok(persona);
        }
        [HttpDelete("{dni}")]
        public ActionResult borrarPersona(Persona persona)
        {
            var BorrarPersona = ListPersona.Find(x => x.dni == persona.dni);
            if (BorrarPersona == null)
            {
                return NotFound();
            }
            ListPersona.Remove(BorrarPersona);
           
            return Ok();
        }

    }
}
