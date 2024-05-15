using Microsoft.AspNetCore.Mvc;
using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Controllers
{
    [ApiController]
    [Route("api/historial")]
    public class HistorialControllers : ControllerBase
    {
        static List<Historial> ListHistoria = new List<Historial>()
        {
            new Historial("452236",(new Animal(1,"Milo", "Terranoba", 7, "macho", "Perro",new Persona("45353230", "Victoria", "Arias"))), DateTime.Now,"vacunacion", "colocacion de infectable", "vacuna contra ravia"),
            new Historial("458695",(new Animal(2,"Molly", "kho manee", 5, "Hembra", "gato ",new Persona("46695", "mica", "colman"))), DateTime.Now,"factura", "operacioon", "analgesico"),
        };

        [HttpGet]
        public List<Historial> ConsultarHistorial()
        {
            return ListHistoria;
        }

        [HttpPost]
        public string CrearHistorial(Historial historial)
        {
            ListHistoria.Add(historial);
            return historial.Id_Historial;
        }
        [HttpPut("{Id_historial}")]
        public ActionResult ActualizarHistorial(Historial historial)
        {
            var ActualizarHistorial = ListHistoria.Find(x => x.Id_Historial == historial.Id_Historial );

            if (ActualizarHistorial == null)
            {
                return NotFound();
            }

            ActualizarHistorial.tratamiento = historial.tratamiento;
            ActualizarHistorial.medicamento = historial.medicamento;
            ActualizarHistorial.motivo_consulta = historial.motivo_consulta;

            return Ok();
        }
        [HttpGet("{Id_historial}")]
        public ActionResult ConsultarHistorial(string id)
        {
            var historial = ListHistoria.Find(x => x.Id_Historial == id);
            if (historial == null)
            {
                return NotFound();
            }
            return Ok(historial);
        }
        [HttpDelete("{Id_historial}")]
        public ActionResult borrarHistorial(Historial historial)
        {
            var BorrarHistorial = ListHistoria.Find(x => x.Id_Historial == historial.Id_Historial);
            if (BorrarHistorial == null)
            {
                return NotFound();
            }
            ListHistoria.Remove(BorrarHistorial);
            return Ok();
        }

    }
}
