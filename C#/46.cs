using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46
{
    /*
     * Dado un array de números enteros positivos, donde cada uno
     * representa unidades de bloques apilados, debemos calcular cuantas unidades
     * de agua quedarán atrapadas entre ellos.
     *
     * - Ejemplo: Dado el array [4, 0, 3, 6, 1, 3].
     *
     *          ⏹
     *          ⏹
     *   ⏹💧💧⏹
     *   ⏹💧⏹⏹💧⏹
     *   ⏹💧⏹⏹💧⏹
     *   ⏹💧⏹⏹⏹⏹
     *
     *   Representando bloque con ⏹︎ y agua con 💧, quedarán atrapadas 7 unidades
     *   de agua. Suponemos que existe un suelo impermeable en la parte inferior
     *   que retiene el agua.
     */
    public class ContenedorAgua
    {
        /** Mi intento**/
        public int UnidadesDeAgua(int[] container)
        {
            int bloques = 0;
            int bigger = 0;
            int contadorAgua = 0;
            foreach (int i in container)
            {
                if (i > bigger) bigger = i;
            }
            // armo matriz y coloco bloques
            char?[,] matriz = new char?[bigger, container.Length];
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                bloques = container[c];
                for (int f = matriz.GetLength(0) - 1; f >= 0; f--)
                {
                    if (bloques > 0) matriz[f, c] = '⏹';
                    bloques--;
                }
            }
            // coloco el agua y cuento
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j != 0 && j != matriz.GetLength(1) - 1)
                    {
                        if (i == matriz.GetLength(0) - 1)
                        {
                            if (matriz[i, j] is null)
                            {
                                matriz[i, j] = 'A';
                                contadorAgua++;
                            }
                        }
                        else if (matriz[i, j - 1] is not null && matriz[i, j] != '⏹' && ((j + 1) != matriz.GetLength(1) - 1 || matriz[i, j + 1] is not null)/*&& matriz[i, j + 1] is not null*/)
                        {
                            matriz[i, j] = 'A';
                            contadorAgua++;
                        }
                    }
                }
            }
            return contadorAgua;
        }
        /** IA **/
        public int UnidadesDeAguaIA(int[] container)
        {
            // Si hay menos de 3 bloques, es imposible hacer un cuenco
            if (container.Length < 3) return 0;

            int aguaTotal = 0;
            int length = container.Length;

            // Arrays para guardar la pared más alta que cada bloque ve a su izquierda y derecha
            int[] maxIzq = new int[length];
            int[] maxDer = new int[length];

            // 1. Escaneamos de Izquierda a Derecha para ver el muro más alto a la izquierda
            maxIzq[0] = container[0];
            for (int i = 1; i < length; i++)
            {
                maxIzq[i] = Math.Max(maxIzq[i - 1], container[i]);
            }

            // 2. Escaneamos de Derecha a Izquierda para ver el muro más alto a la derecha
            maxDer[length - 1] = container[length - 1];
            for (int i = length - 2; i >= 0; i--)
            {
                maxDer[i] = Math.Max(maxDer[i + 1], container[i]);
            }

            // 3. Calculamos el agua para cada posición usando la Regla de Oro
            for (int i = 0; i < length; i++)
            {
                // El nivel del agua será el muro más bajo entre los dos muros máximos
                int nivelAgua = Math.Min(maxIzq[i], maxDer[i]);

                // Le restamos la altura del bloque actual
                aguaTotal += nivelAgua - container[i];
            }

            return aguaTotal;
        }
    }
}
