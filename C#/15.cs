using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    /*
     * Escribe una función que calcule si un número dado es un número de Armstrong
     * (o también llamado narcisista).
     * Si no conoces qué es un número de Armstrong, debes buscar información
     * al respecto.
     */
    public class Amstrong
    {
        public bool EsAmstrong(int numero)
        {
            string numeroString = numero.ToString();
            int longitud = numeroString.Length;
            int suma = 0;
            foreach (char c in numeroString)
            {
                int digito = (int)char.GetNumericValue(c);
                suma += (int)Math.Pow(digito, longitud);
            }
            return suma == numero;
        }
    }
}
