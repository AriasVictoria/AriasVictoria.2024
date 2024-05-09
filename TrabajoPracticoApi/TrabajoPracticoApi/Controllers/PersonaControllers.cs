using Microsoft.AspNetCore.Mvc;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Controllers
{
    public class PersonaControllers : ControllerBase
    {
        static List<Persona> ListPersona = new List<Persona>()
        {
            new Persona("45353230", "Victoria", "Arias"),
            new Persona("45342888", "Maria Lara", "Morelli"),
        };

        [HttpGet]
        public List<Persona> ConsultarPersoona()
        {
            return ListPersona;
        }

        [HttpPost]
        public string ConsultarPersona(Persona persona)
        {
            ListPersona.Add(persona);
            return persona.dni;
        }
        [HttpPut("{DNI}")]
        public ActionResult ActualizarPersona(string dni, Persona persona)
        {
            var ActualizarPersona = ListPersona.Find(x => x.dni == dni);

            if (ActualizarPersona == null)
            {
                return NotFound();
            }

            persona.dni = persona.dni;

            return Ok();
        }
        [HttpGet("{DNI}")]
        public ActionResult ConsultarPersona(string dni)
        {
            var persona = ListPersona.Find(x => x.dni == dni);
            if (persona == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpDelete("{DNI}")]
        public ActionResult borrarPersona(string dni)
        {
            var BorrarPersona = ListPersona.Find(x => x.dni == dni);
            if (BorrarPersona == null)
            {
                return NotFound();
            }
            ListPersona.Remove(BorrarPersona);
            return Ok();
        }

    }
}
