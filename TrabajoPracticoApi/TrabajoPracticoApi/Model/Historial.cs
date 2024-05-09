namespace TrabajoPracticoApi.Model
{
    public class Historial
    {
        public Animal animal { get; set; }
        public Persona persona { get; set; }
        public DateTime fecha_consulta { get; set; }
        public string motivo_consulta { get; set; }
        public string tratamiento { get; set; }
        public string medicamento { get; set; }
        
    }
}
