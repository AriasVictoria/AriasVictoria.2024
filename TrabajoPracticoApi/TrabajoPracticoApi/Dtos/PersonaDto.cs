namespace TrabajoPracticoApi.DtoAnimal
{
    public class PersonaDto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public PersonaDto(string Nombre, string Telefono)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
        }
    }
}
