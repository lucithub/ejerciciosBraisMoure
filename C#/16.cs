using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    public class CuantosDias
    {
        /*
         * Crea una función que calcule y retorne cuántos días hay entre dos cadenas
         * de texto que representen fechas.
         * - Una cadena de texto que representa una fecha tiene el formato "dd/MM/yyyy".
         * - La función recibirá dos String y retornará un Int.
         * - La diferencia en días será absoluta (no importa el orden de las fechas).
         * - Si una de las dos cadenas de texto no representa una fecha correcta se
         *   lanzará una excepción.
         */
        public int CalcularDiasEntreFechas(string f1, string f2)
        {
            if (!IsValidFormatDate(f1) || !IsValidFormatDate(f2)) 
            {
                throw new Exception("Ingrese una fecha valida.");
            }
            TimeSpan diferencia = new TimeSpan();
            string[] fechas = f1.Split('/');
            DateTime fechaUno = new DateTime(int.Parse(fechas[2]), int.Parse(fechas[1]), int.Parse(fechas[0]));
            string[] fechasDos = f2.Split('/');
            DateTime fechaDos = new DateTime(int.Parse(fechasDos[2]), int.Parse(fechasDos[1]), int.Parse(fechasDos[0]));
            return Math.Abs((fechaUno - fechaDos).Days);
        }
        public bool IsValidFormatDate(string fecha)
        {
            string formato = "dd/MM/yyyy";
            DateTime fechaie;

            if (DateTime.TryParseExact(fecha, formato, null, System.Globalization.DateTimeStyles.None, out fechaie))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
