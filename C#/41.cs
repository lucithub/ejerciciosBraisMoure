using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    /*
     * Crea una función que sea capaz de dibujar el "Triángulo de Pascal"
     * indicándole únicamente el tamaño del lado.
     *
     * - Aquí puedes ver rápidamente cómo se calcula el triángulo:
     *   https://commons.wikimedia.org/wiki/File:PascalTriangleAnimated2.gif
     */
    public class TrianguloDePascal
    {
        public void DrawPascalTriangle(int size)
        {
            int[,] triangulo = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i) triangulo[i, j] = 1;
                    else
                    {
                        triangulo[i, j] = triangulo[i - 1, j - 1] + triangulo[i - 1, j];
                    }
                    Console.Write(triangulo[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
