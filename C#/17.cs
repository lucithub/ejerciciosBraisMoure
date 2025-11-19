using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    /*
     * Crea una función que reciba un String de cualquier tipo y se encargue de
     * poner en mayúscula la primera letra de cada palabra.
     * - No se pueden utilizar operaciones del lenguaje que
     *   lo resuelvan directamente.
     */
    public class EnMayuscula
    {
        public string SepararPalabras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "Revise si ingreso alguna palabra.";
            }
            string[] textos = texto.Split(" ");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < textos.Length; i++)
            {
                sb.Append(ToUpperCaseFirstLetter(textos[i]));
                if (i < textos.Length - 1)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
        public string ToUpperCaseFirstLetter(string texto)
        {
            char letra = texto[0];
            char letraMayuscula = ' ';
            if (letra >= 'a' && letra <= 'z')
            { 
                letraMayuscula = (char)(letra - ('a' - 'A'));
                texto = texto.Remove(0, 1);
                texto = letraMayuscula + texto;
            }
            else
            {
                if (letra >= 'A' && letra <= 'Z')
                {
                    return texto;
                }
                else
                {
                    return "La primera letra no esta ni en mayuscula ni minuscula. Por favor, revise el texto que ingreso, e intente otra vez.";
                }
            }
            return texto;
        }
    }
}
