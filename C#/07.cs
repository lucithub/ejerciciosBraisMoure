/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */
internal class InvirtiendoCadenas
{
    public string InvertirCadena(string cadena)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            sb.Append(cadena[i]);
        }
        return sb.ToString();
    }
}
