using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _13
{
    /*
     * Escribe una función que reciba un texto y retorne verdadero o
     * falso (Boolean) según sean o no palíndromos.
     * Un Palíndromo es una palabra o expresión que es igual si se lee
     * de izquierda a derecha que de derecha a izquierda.
     * NO se tienen en cuenta los espacios, signos de puntuación y tildes.
     * Ejemplo: Ana lleva al oso la avellana.
     */
    public class Palindromo
    {
        public bool EsPalindromo(string texto)
        {
            string textoSinCaracteres = Regex.Replace(texto, "[^\\w]", "");
            textoSinCaracteres = textoSinCaracteres.ToLower();
            if (string.IsNullOrEmpty(textoSinCaracteres))
            {
                return false;
            }
            string textoReversed = new string(textoSinCaracteres.Reverse().ToArray());
            for (int i = 0; i < textoSinCaracteres.Length; i++)
            {
                if (textoSinCaracteres[i] != textoReversed[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
