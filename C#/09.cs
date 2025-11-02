using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    /*
     * Crea un programa se encargue de transformar un número
     * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
     */
    internal class DecimalToBinary
    {
        public string convertir(int numero)
        {
            if (numero == 0) return "0";
            string binario = "";
            while (numero > 0)
            { 
                binario = (numero % 2) + binario;
                numero = numero / 2;
            }
            return binario;
        }
    }
}
