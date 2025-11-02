using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08
{
    /*
     * Crea un programa que cuente cuantas veces se repite cada palabra
     * y que muestre el recuento final de todas ellas.
     * - Los signos de puntuación no forman parte de la palabra.
     * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
     * - No se pueden utilizar funciones propias del lenguaje que
     *   lo resuelvan automáticamente.
     */
    public class ContadorPalabras
    {
        public static Dictionary<string, int> ContarPalabras(string oracion)
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();
            oracion = oracion.ToLower();
            oracion = Regex.Replace(oracion, @"[^\w\s@]+", "");
            string[] p = oracion.Split(' ');
            for (int i = 0; i < p.Length; i++)
            {
                if (!palabras.ContainsKey(p[i]))
                {
                    palabras.Add(p[i], 1);
                }
                else
                {
                    palabras[p[i]] = palabras[p[i]] + 1;
                }
            }
            return palabras;
        }
    }
}
