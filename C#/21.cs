using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    /*
     * Crea una función que sume 2 números y retorne su resultado pasados
     * unos segundos.
     * - Recibirá por parámetros los 2 números a sumar y los segundos que
     *   debe tardar en finalizar su ejecución.
     * - Si el lenguaje lo soporta, deberá retornar el resultado de forma
     *   asíncrona, es decir, sin detener la ejecución del programa principal.
     *   Se podría ejecutar varias veces al mismo tiempo.
     */
    public class ParandoElTiempo
    {
        public async Task<int> Add(int n1, int n2, int ttl)
        {
            await Task.Delay(ttl);
            return n1 + n2;
        }
    }
}
