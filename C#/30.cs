using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _30
{
    /*
     * Crea una función que ordene y retorne una matriz de números.
     * - La función recibirá un listado (por ejemplo [2, 4, 6, 8, 9]) y un parámetro
     *   adicional "Asc" o "Desc" para indicar si debe ordenarse de menor a mayor
     *   o de mayor a menor.
     * - No se pueden utilizar funciones propias del lenguaje que lo resuelvan
     *   automáticamente.
     */
    public class OrdenaLaLista
    {
        private List<int> listadoOrdenado = new List<int>();
        public int[] Ordenar(int[] listado, string orden)
        {
            orden = orden.ToLower();
            if (orden == "asc") listadoOrdenado = MenorAMayor(listado).ToList();
            else if (orden == "desc") listadoOrdenado = MayorAMenor(listado).ToList();
            else return Array.Empty<int>();
                return listadoOrdenado.ToArray();
        }
        private int[] MenorAMayor(int[] listado)
        {
            int n = listado.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listado[j] > listado[j + 1])
                    {
                        int temp = listado[j];
                        listado[j] = listado[j + 1];
                        listado[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return listado;
        }
        private int[] MayorAMenor(int[] listado)
        {
            int n = listado.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (listado[j] < listado[j + 1])
                    {
                        int temp = listado[j];
                        listado[j] = listado[j + 1];
                        listado[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
            return listado;
        }
    }
}
