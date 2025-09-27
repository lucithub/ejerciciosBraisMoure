/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
Console.WriteLine("El numero 1 de Fibonacci es: 0");
Console.WriteLine("El numero 1 de Fibonacci es: 1");
long n1 = 0, n2 = 1, suma = 0;
for (int i = 3; i < 51; i++)
{
    suma = n1 + n2;
    Console.WriteLine($"El numero {i} de Fibonacci es: {suma}");
    n1 = n2;
    n2 = suma;
}
