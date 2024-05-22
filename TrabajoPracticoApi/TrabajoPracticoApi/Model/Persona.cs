namespace TrabajoPracticoApi.Model
{
    public class Persona
    {
        public string dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public Persona(string dni, string nombre, string apellido, string telefono)
        {
            this.dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            Telefono = telefono;
        }
    }
}
