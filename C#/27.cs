using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    /*
     * Crea un programa que dibuje un cuadrado o un triángulo con asteriscos "*".
     * - Indicaremos el tamaño del lado y si la figura a dibujar es una u otra.
     * - EXTRA: ¿Eres capaz de dibujar más figuras?
     */
    public class Drawer
    {
        public string[,] EventHandler(int size, string figure)
        {
            figure = figure.ToLower().Trim();
            if (figure == "cuadrado")
            {
                return DrawSquare(size);
            } 
            if (figure == "triangulo" || figure == "triángulo")
            {
                return DrawTriangle(size);
            }
            else return new string[size, size];    
        }
        public string[,] DrawSquare(int size) 
        {
            string[,] square = new string[size, size];
            for (int i = 0; i < square.GetLength(0); i++) 
            {
                for (int j = 0; j < square.GetLength(1); j++) 
                {
                    if (i == 0 || i == size - 1) square[i, j] = "*";
                    else if (j == 0 || j == size - 1) square[i, j] = "*";
                    else square[i, j] = " ";
                }
            }
            return square;
        }
        public string[,] DrawTriangle(int size)
        {
            if (size % 2 == 0) throw new Exception("El tamanio del triangulo debe ser un numero IMPAR");
            string[,] triangle = new string[size, size];
            int topOfTriangle = size / 2;
            int nextPointLeft = topOfTriangle - 1; int nextPointRight = topOfTriangle + 1;
            int indexNPR = 1;
            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                for (int j = 0; j < triangle.GetLength(1); j++)
                {
                    triangle[i, j] = " ";
                    if (i <= topOfTriangle)
                    {
                        if (i == topOfTriangle)
                        {
                            triangle[i, j] = "*";
                        }
                        else if (j == topOfTriangle - i)
                        {
                            triangle[i, j] = "*";
                        }
                        else if (j == topOfTriangle + i)
                        {
                            triangle[i, j] = "*";
                        }
                    }
                }
            }
            return triangle;
        }
    }
}
