using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    /*
     * Crea una función que reciba dos array, un booleano y retorne un array.
     * - Si el booleano es verdadero buscará y retornará los elementos comunes
     *   de los dos array.
     * - Si el booleano es falso buscará y retornará los elementos no comunes
     *   de los dos array.
     * - No se pueden utilizar operaciones del lenguaje que
     *   lo resuelvan directamente.
     */
    public class Conjuntos
    {
        public string[] BuscarConjuntos(string[] a1, string[] a2, bool boolean)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict = SearchElements(a1, a2);
            List<string> list = new List<string>();
            if (boolean)
            {
                foreach (string s in dict.Keys)
                {
                    if (dict.GetValueOrDefault(s) > 1)
                    {
                        list.Add(s);
                    }
                }
            }
            else
            {
                foreach (string s in dict.Keys)
                {
                    if (dict.GetValueOrDefault(s) == 1)
                    {
                        list.Add(s);
                    }
                }
            }
            return list.ToArray();
        }
        public Dictionary<string, int> SearchElements(string[] a1, string[] a2)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string s in a1) 
            {
                if (dict.ContainsKey(s))
                {
                    dict[s] += 1;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            foreach (string s in a2)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s] += 1;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            return dict;
        }
    }
}
