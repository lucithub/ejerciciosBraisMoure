using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    /*
     * Crea un programa se encargue de transformar un número binario
     * a decimal sin utilizar funciones propias del lenguaje que
     * lo hagan directamente.
     */
    public class BinaryToDecimal
    {
        public int Convert(int binary)
        {
            int number = binary;
            int index = 0;
            List<int> arrBinary = new List<int>();
            while (number > 0)
            {
                arrBinary.Add(number % 10);
                number /= 10;
            }
            List<int> res = new List<int>();
            foreach (var digit in arrBinary)
            {
                res.Add((int)(digit * Math.Pow(2, index)));
                index++;
            }
            int total = 0;
            foreach (var item in res)
            {
                total += item;
            }
            return total;
        }
    }
}
