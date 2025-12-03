using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    /*
     * Crea dos funciones, una que calcule el máximo común divisor (MCD) y otra
     * que calcule el mínimo común múltiplo (mcm) de dos números enteros.
     * - No se pueden utilizar operaciones del lenguaje que
     *   lo resuelvan directamente.
     */
    public class MCDMCM
    {
        public int Mcd(int n1, int n2)
        {
            while (n1 != 0 && n2 != 0)
            {
                var temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            return n1 + n2;
        }
        public int Mcm(int n1, int n2)
        {
            return (n1 * n2) / Mcd(n1, n2);
        }
    }
}
