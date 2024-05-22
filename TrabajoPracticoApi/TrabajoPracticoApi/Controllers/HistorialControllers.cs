using Microsoft.AspNetCore.Mvc;
using TrabajoPracticoApi.DtoAnimal;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Controllers
{
    [ApiController]
    [Route("api/historial")]

    public class HistorialControllers : ControllerBase
    {
        static List<Historial> ListHistorial = new List<Historial>()
        {
            new Historial(1,(new Animal(1,"Milo", "Terranoba", 7, "macho", "Perro","45353230")),
                DateTime.Now,"vacunacion", "colocacion de infectable", "vacuna contra ravia"),
            new Historial(2,(new Animal(2,"Molly", "kho manee", 5, "Hembra", "gato ","45342888")),
                DateTime.Now,"factura", "operacioon", "analgesico"),
        };

        [HttpGet]
        public List<Historial> ConsultarHistorial()
        {
            return ListHistorial;
        }

        [HttpPost]
        public int CrearHistorial(Historial historial)
        {
            ListHistorial.Add(historial);
            return historial.id;
        }
        [HttpPut("{id}")]
        public ActionResult ActualizarHistorial(Historial historial)
        {
            var ActualizarHistorial = ListHistorial.Find(x => x.id == historial.id );

            if (ActualizarHistorial == null)
            {
                return NotFound();
            }

            ActualizarHistorial.tratamiento = historial.tratamiento;
            ActualizarHistorial.medicamento = historial.medicamento;
            ActualizarHistorial.motivo_consulta = historial.motivo_consulta;

            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult ConsultarHistorial(int id)
        {
            var historial = ListHistorial.Find(x => x.id == id);
            if (historial == null)
            {
                return NotFound();
            }
            return Ok(historial);
        }
        [HttpDelete("{id}")]
        public ActionResult borrarHistorial(int id)
        {
            var historialBorrar = ListHistorial.Find(x => x.id == id);
            if (historialBorrar == null)
            {
                return NotFound();
            }
            ListHistorial.Remove(historialBorrar);

            return Ok();
        }
    }
}
