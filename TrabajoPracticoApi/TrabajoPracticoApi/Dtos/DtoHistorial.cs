using TrabajoPracticoApi.Model;

namespace TrabajoPracticoApi.Dtos
{
    public class DtoHistorial
    {
        public int id_Historial { get; set; }
        public int id_animal { get; set; }
        public DateTime fecha_consulta { get; set; }
        public string motivo_consulta { get; set; }
        public string tratamiento { get; set; }
        public string medicamento { get; set; }
        public DtoHistorial(int id_Historial, int id_animal, DateTime fecha_consulta, string motivo_consulta, string tratamiento, string medicamento)
        {
            this.id_Historial = id_Historial;
            this.id_animal = id_animal;
            this.fecha_consulta = DateTime.Now;
            this.motivo_consulta = motivo_consulta;
            this.tratamiento = tratamiento;
            this.medicamento = medicamento;
        }
    }
}
