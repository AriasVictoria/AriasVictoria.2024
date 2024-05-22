using System.Globalization;
using System.Net;
using TrabajoPracticoApi.DtoAnimal;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public string dueño { get; set; }
       
        public Animal(int id, string nombreAnimal, string raza, int edad,string sexo, string tipoAnimal, string dueño)
        {
            this.id = id;
            this.nombreAnimal = nombreAnimal;
            this.raza = raza;
            this.edad = edad;
            this.sexo = sexo;
            this.tipoAnimal = tipoAnimal;
            this.dueño = dueño;
        }
    }
}
