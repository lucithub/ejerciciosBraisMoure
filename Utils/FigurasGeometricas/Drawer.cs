namespace FigurasGeometricasLIV
{
    public class Drawer
    {
        public static string[,] DrawSquare(int size)
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
        public static string[,] DrawTriangle(int size)
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
