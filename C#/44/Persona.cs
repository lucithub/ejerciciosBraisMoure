using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public int alturaCM { get; set; }
        public Persona(string nombre, int edad, int alturaCM)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.alturaCM = alturaCM;
        }
    }
}
