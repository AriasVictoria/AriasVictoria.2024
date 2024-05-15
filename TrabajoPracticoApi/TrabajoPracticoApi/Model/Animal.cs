using System.Globalization;

namespace TrabajoPracticoApi.Model
{
    public class Animal
    {
        public int id { get; set; }
        public string nombreAnimal { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string tipoAnimal { get; set; }
        public Persona dueño { get; set; }


        public Animal(int id,string nombre, string raza, int edad, string sexo, string tipo, Persona dni)
        {
            this.id = id;
            this.nombreAnimal = nombre;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo; 
            this.tipoAnimal = tipo;
            this.dueño = dni;
        }
    }
}
