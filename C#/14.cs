using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    /*
     * Escribe una función que calcule y retorne el factorial de un número dado
     * de forma recursiva.
     */
    public class Factorial
    {
        public long CalcularFactorial(long n)
        {
            if (n < 0)
            {
                throw new ArgumentException("No se permiten factoriales de numeros negativos.");
            }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalcularFactorial(n - 1);
            }
        }
    }
}
