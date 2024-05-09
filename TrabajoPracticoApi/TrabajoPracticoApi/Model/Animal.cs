using System.Globalization;

namespace TrabajoPracticoApi.Model
{
    public class Animal
    {
        public string nombreAnimal { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string tipoAnimal { get; set; }
        public Persona dueño { get; set; }

        public Animal(string Nombreanimal, string raza, int edad, string sexo, string tipo, string Dueño)
        {
            this.nombreAnimal = Nombreanimal;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo; 
            this.tipoAnimal = tipo;
        }
    }
}
