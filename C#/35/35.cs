using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _35
{
    /*
     * Dado un array de enteros ordenado y sin repetidos,
     * crea una función que calcule y retorne todos los que faltan entre
     * el mayor y el menor.
     * - Lanza un error si el array de entrada no es correcto.
     */
    public class NumerosPerdidos
    {
        public int[] FindLostNumbers(int[] numbers)
        {
            if (!IsStL(numbers) && !IsLtS(numbers))
            {
                throw new OrderException("el array de entrada no es correcto.");
            }
            else
            {
                int older = numbers.Last();
                int smaller = numbers.First();
                if (older < smaller)
                {
                    Array.Sort(numbers);
                    older = numbers.Last();
                    smaller = numbers.First();
                }
                List<int> numberss = numbers.ToList();
                List<int> numbersBetween = new List<int>();
                for (int i = smaller; i < older; i++)
                {
                    if (!numberss.Contains(i)) numbersBetween.Add(i);
                }
                return numbersBetween.ToArray();
            }
        }

        /** It goes from smallest to largest? <- RAZON DEL NOMBRE DEL METODO **/
        private bool IsStL(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] >= numbers[i + 1]) return false;
            }
            return true;
        }
        /** It goes from larger to smallest? <- RAZON DEL NOMBRE DEL METODO **/
        private bool IsLtS(int[] numbers)
        {
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                if (numbers[i] >= numbers[i - 1]) return false;
            }
            return true;
        }
    }
}
