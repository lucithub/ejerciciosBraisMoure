using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    /*
     * Implementa uno de los algoritmos de ordenación más famosos:
     * el "Quick Sort", creado por C.A.R. Hoare.
     * - Entender el funcionamiento de los algoritmos más utilizados de la historia
     *   Nos ayuda a mejorar nuestro conocimiento sobre ingeniería de software.
     *   Dedícale tiempo a entenderlo, no únicamente a copiar su implementación.
     * - Esta es una nueva serie de retos llamada "TOP ALGORITMOS",
     *   donde trabajaremos y entenderemos los más famosos de la historia.
     */
    public class QuickSort
    {
        // 1. Dividir
        // 2. Conquistar (con recursividad)
        // 3. Combinar
        public void QuickSortImpl(int[] array, int izq, int der)
        {
            if (izq < der)
            {
                int pivote = Particion(array, izq, der);
                QuickSortImpl(array, izq, pivote - 1);
                QuickSortImpl(array, pivote + 1, der);
            }
        }

        private static int Particion(int[] array, int izq, int der)
        {
            int pivote = array[der];
            int peque = izq - 1;
            int temp = 0;

            for (int i = izq; i < der; i++)
            {
                if (array[i] < pivote)
                {
                    peque++;
                    temp = array[peque];
                    array[peque] = array[i];
                    array[i] = temp;
                }
            }
            (array[peque + 1], array[der]) = (array[der], array[peque + 1]);
            return peque + 1;
        }
    }
}
