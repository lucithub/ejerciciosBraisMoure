using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    /*
     * Crea una función que reciba días, horas, minutos y segundos (como enteros)
     * y retorne su resultado en milisegundos.
     */
    public class ConversorTiempo
    {
        public long ConvertToMS(int day, int hour, int minute, int second)
        {
            return (long)(day * 86400000 + hour * 3600000 + minute * 60000 + second * 1000);
        }
    }
}
