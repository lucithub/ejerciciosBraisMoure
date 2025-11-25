using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    /*
     * Crea una función que analice una matriz 3x3 compuesta por "X" y "O"
     * y retorne lo siguiente:
     * - "X" si han ganado las "X"
     * - "O" si han ganado los "O"
     * - "Empate" si ha habido un empate
     * - "Nulo" si la proporción de "X", de "O", o de la matriz no es correcta.
     *   O si han ganado los 2.
     * Nota: La matriz puede no estar totalmente cubierta.
     * Se podría representar con un vacío "", por ejemplo.
     */
    public class TresEnRaya
    {
        public string MainFunction(string[,] matriz)
        {
            if (EsResultadoNulo(matriz)) return "Nulo";
            if (GanoX(matriz)) return "X";
            if (GanoO(matriz)) return "O";
            else return "Empate";
        }

        public bool EsResultadoNulo(string[,] matriz) 
        {
            int xCount = 0;
            int oCount = 0;
            if (matriz.GetLength(0) != 3 || matriz.GetLength(1) != 3) return true;
            foreach (var item in matriz)
            {
                if (item == "X") xCount++;
                if (item == "O") oCount++;
            }
            if ((xCount - oCount) > 1 || (xCount - oCount) < -1) return true;
            if (GanoO(matriz) && GanoX(matriz)) return true;
            return false;
        }

        public bool GanoX(string[,] matriz)
        {
            // Verificar filas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] == "X" && matriz[i, 1] == "X" && matriz[i, 2] == "X")
                {
                    return true;
                }
            }

            // Verificar columnas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[0, i] == "X" && matriz[1, i] == "X" && matriz[2, i] == "X")
                {
                    return true;
                }
            }

            // Verificar diagonales
            if (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X")
            {
                return true;
            }
            if (matriz[0, 2] == "X" && matriz[1, 1] == "X" && matriz[2, 0] == "X")
            {
                return true;
            }
            return false;
        }

        public bool GanoO(string[,] matriz)
        {
            // Verificar filas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[i, 0] == "O" && matriz[i, 1] == "O" && matriz[i, 2] == "O")
                {
                    return true;
                }
            }

            // Verificar columnas
            for (int i = 0; i < 3; i++)
            {
                if (matriz[0, i] == "O" && matriz[1, i] == "O" && matriz[2, i] == "O")
                {
                    return true;
                }
            }

            // Verificar diagonales
            if (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O")
            {
                return true;
            }
            if (matriz[0, 2] == "O" && matriz[1, 1] == "O" && matriz[2, 0] == "O")
            {
                return true;
            }
            return false;
        }
    }
}
