using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11
{
    /*
     * Crea un programa que comprueba si los paréntesis, llaves y corchetes
     * de una expresión están equilibrados.
     * - Equilibrado significa que estos delimitadores se abren y cieran
     *   en orden y de forma correcta.
     * - Paréntesis, llaves y corchetes son igual de prioritarios.
     *   No hay uno más importante que otro.
     * - Expresión balanceada: { [ a * ( c + d ) ] - 5 }
     * - Expresión no balanceada: { a * ( c + d ) ] - 5 }
     */
    public class ExpresionesEqulibradas
    {
        public bool VerificarExpresion(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) || cadena.Length <= 1) return false;
            string cadenaSinLetras = Regex.Replace(cadena, @"[^(){}[\]]+", "");
            string cadenaSLInversa = string.Join("", cadenaSinLetras.ToCharArray().Reverse());
            if (string.IsNullOrEmpty(cadenaSinLetras) || cadenaSinLetras.Length <= 1) return false;
            for (int i = 0; i < cadenaSinLetras.Length; i++)
            {
                switch (cadenaSinLetras[i])
                {
                    case '{' or '}':
                        if (cadenaSLInversa[i] is not ('{') and not ('}'))
                        {
                            return false;
                        }
                        break;
                    case '[' or ']':
                        if (cadenaSLInversa[i] is not ('[') and not (']'))
                        {
                            return false;
                        }
                        break;
                    case '(' or ')':
                        if (cadenaSLInversa[i] is not ('(') and not (')'))
                        {
                            return false;
                        }
                        break;
                }
            }
            return true;
        }
    }
}
