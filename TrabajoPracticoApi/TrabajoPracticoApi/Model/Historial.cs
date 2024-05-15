namespace TrabajoPracticoApi.Model
{
    public class Historial
    {
        public string Id_Historial { get; set; }
        public Animal animal { get; set; }
        public DateTime fecha_consulta { get; set; }
        public string motivo_consulta { get; set; }
        public string tratamiento { get; set; }
        public string medicamento { get; set; }

        public Historial(string Id_Historial,Animal animal,DateTime fecha, string consulta, string tratamiento, string medicamento )
        {
            this.Id_Historial = Id_Historial;
            this.animal = animal;
            this.fecha_consulta = DateTime.Now;
            this.motivo_consulta = consulta;
            this.tratamiento = tratamiento;
            this.medicamento = medicamento;
        }
    }
}
