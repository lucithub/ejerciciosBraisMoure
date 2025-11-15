using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    /*
     * Crea una función que reciba dos cadenas como parámetro (str1, str2)
     * e imprima otras dos cadenas como salida (out1, out2).
     * - out1 contendrá todos los caracteres presentes en la str1 pero NO
     *   estén presentes en str2.
     * - out2 contendrá todos los caracteres presentes en la str2 pero NO
     *   estén presentes en str1.
     */
    public class EliminandoCaracteres
    {
        public List<string> eliminar(string str1, string str2)
        {
            var set1 = new HashSet<char>(str1);
            var set2 = new HashSet<char>(str2);
            StringBuilder out1 = new StringBuilder();
            StringBuilder out2 = new StringBuilder();
            foreach (var c in str1)
            {
                if (!set2.Contains(c))
                {
                    out1.Append(c);
                }
            }
            foreach (var c in str2)
            {
                if (!set1.Contains(c))
                {
                    out2.Append(c);
                }
            }
            return new List<string> { out1.ToString(), out2.ToString() };
        }
    }
}
