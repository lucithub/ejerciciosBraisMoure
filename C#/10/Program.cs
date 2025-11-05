using _10;

public class Program
{
    public static void Main(string[] args)
    {
        NaturalToMorse.RellenarDictionaries();
        NaturalToMorse conversor = new NaturalToMorse();

        // --- Pruebas de Conversión ---

        Console.WriteLine("--- Conversión de Natural a Morse ---");
        string textoNatural = "Hola mundo 10";
        string morseConvertido = conversor.Convertir(textoNatural);
        Console.WriteLine($"Original: \"{textoNatural}\"");
        Console.WriteLine($"Morse:    \"{morseConvertido}\""); // Debería ser: ".... --- .-.. .-   -- ..- -. -.. ---   .---- -----"

        Console.WriteLine("\n--- Conversión de Morse a Natural ---");
        // Usamos el resultado de la conversión anterior
        string morseInput = morseConvertido;
        string textoConvertido = conversor.Convertir(morseInput);
        Console.WriteLine($"Original: \"{morseInput}\"");
        Console.WriteLine($"Natural:  \"{textoConvertido}\""); // Debería ser: "HOLA MUNDO 10"

        Console.WriteLine("\n--- Pruebas Adicionales ---");
        string pruebaNatural = "mouredev";
        string pruebaMorse = conversor.Convertir(pruebaNatural);
        Console.WriteLine($"\"{pruebaNatural}\" -> \"{pruebaMorse}\"");
        Console.WriteLine($"\"{pruebaMorse}\" -> \"{conversor.Convertir(pruebaMorse)}\"");

        Console.ReadKey();
    }
}
