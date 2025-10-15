/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */
internal class NumerosPrimos
{
    public bool esPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
