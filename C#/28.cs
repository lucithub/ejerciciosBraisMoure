using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    /*
     * Crea un programa que determine si dos vectores son ortogonales.
     * - Los dos array deben tener la misma longitud.
     * - Cada vector se podría representar como un array. Ejemplo: [1, -2]
     */
    public class VectoresOrtogonales
    {
        public bool EsVectorOrtogonal(int[] arr1, int[] arr2)
        {
            long suma = 0;
            if (arr1.Length != arr2.Length) return false;
            for (int i = 0; i < arr2.Length; i++)
            {
                suma = suma + (arr1[i] * arr2[i]);
            }
            return suma == 0;
        }
    }
}
