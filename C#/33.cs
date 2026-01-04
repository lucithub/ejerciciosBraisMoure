using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    /*
     * Dado un listado de números, encuentra el SEGUNDO más grande
     */
    public class ElSegundo
    {
        public int FindSecond(List<int> numbers)
        {
            if (numbers.Count < 2 || numbers == null) throw new Exception("Ingrese mas de dos numeros porfavor.");
            numbers = numbers.OrderDescending().ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] != numbers[i + 1]) return numbers[i + 1];
            }
            throw new Exception("Todos los numeros son iguales. Intentelo de nuevo con otros numeros.");
        }
    }
}
