/*
 * Quiero contar del 1 al 100 de uno en uno (imprimiendo cada uno).
 * ¿De cuántas maneras eres capaz de hacerlo?
 * Crea el código para cada una de ellas.
 */
/** 1 X 1 **/
Console.WriteLine("1");
Console.WriteLine("Y asi hasta 100..");
/** BUCLE FOR **/
for (int i = 1; i < 101; i++)
{
    Console.WriteLine(i);
}
/** BUCLE WHILE **/
int num = 1;
while (num < 101)
{
    Console.WriteLine(num);
    num++;
}
/** BUCLE DO WHILE **/
num = 1;
do
{
    Console.WriteLine(num);
    num++;
} while (num < 101);
/** FOR EACH **/
List<int> numeros  = new List<int>();
for (int i = 1; i < 101; i++)
{
    numeros.Add(i);
}
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
