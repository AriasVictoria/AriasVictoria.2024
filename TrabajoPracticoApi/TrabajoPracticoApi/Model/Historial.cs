namespace TrabajoPracticoApi.Model
{
    public class Historial
    {
        public int id{ get; set; }
        public Animal animal { get; set; }
        public DateTime fecha_consulta { get; set; }
        public string motivo_consulta { get; set; }
        public string tratamiento { get; set; }
        public string medicamento { get; set; }

        public Historial(int id, Animal animal,DateTime fecha_consulta, string motivo_consulta, string tratamiento, string medicamento )
        {
            this.id = id;
            this.animal = animal;
            this.fecha_consulta = DateTime.Now;
            this.motivo_consulta = motivo_consulta;
            this.tratamiento = tratamiento;
            this.medicamento = medicamento;
        }
    }
}
