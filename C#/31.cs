using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
{
    /*
     * Crea una función que reciba un texto y muestre cada palabra en una línea,
     * formando un marco rectangular de asteriscos.
     * - ¿Qué te parece el reto? Se vería así:
     *   **********
     *   * ¿Qué   *
     *   * te     *
     *   * parece *
     *   * el     *
     *   * reto?  *
     *   **********
     */
    public class MarcoDePalabras
    {
        public void RealizarMarco(string palabra)
        {
            string[] palabras = palabra.Split(" ");
            int length = LongitudPalabraMasLarga(palabras);
            Console.WriteLine(new string('*', length + 4));
            foreach (string p in palabras)
            {
                Console.Write("* ");
                Console.Write(p);
                Console.Write(new string(' ', length - p.Length));
                Console.Write(" *");
                Console.WriteLine("");
            }
            Console.WriteLine(new string('*', length + 4));
        }

        private int LongitudPalabraMasLarga(string[] palabras)
        {
            int contador = 0;
            foreach (string palabra in palabras)
            {
                if (palabra.Length > contador) contador = palabra.Length;
            }
            return contador;
        }
    }
}
