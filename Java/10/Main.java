/*
 * Crea un programa que sea capaz de transformar texto natural a código
 * morse y viceversa.
 * - Debe detectar automáticamente de qué tipo se trata y realizar
 *   la conversión.
 * - En morse se soporta raya "—", punto ".", un espacio " " entre letras
 *   o símbolos y dos espacios entre palabras "  ".
 * - El alfabeto morse soportado será el mostrado en
 *   https://es.wikipedia.org/wiki/Código_morse.
 */
public class Main {
    public static void main(String[] args) {
        Convertor convertor = new Convertor();

        // Ejemplo 1: Texto natural a morse
        String textoNatural = "HELLO WORLD";
        String morse = convertor.convertir(textoNatural);
        System.out.println("Texto natural: " + textoNatural);
        System.out.println("Convertido a morse: " + morse);

        // Ejemplo 2: Morse a texto natural
        String textoMorse = ".... . .-.. .-.. ---   .-- --- .-. .-.. -..";
        String natural = convertor.convertir(textoMorse);
        System.out.println("Texto morse: " + textoMorse);
        System.out.println("Convertido a texto natural: " + natural);

        // Ejemplo 3: Número en texto natural a morse
        String numeros = "123";
        String morseNumeros = convertor.convertir(numeros);
        System.out.println("Números: " + numeros);
        System.out.println("Convertido a morse: " + morseNumeros);

        // Ejemplo 4: Morse de números a texto natural
        String morseDeNumeros = ".---- ..--- ...--";
        String textoNumeros = convertor.convertir(morseDeNumeros);
        System.out.println("Morse de números: " + morseDeNumeros);
        System.out.println("Convertido a texto natural: " + textoNumeros);

        // Ejemplo 5: Frase con espacio entre palabras
        String frase = "SOS HELP";
        String morseFrase = convertor.convertir(frase);
        System.out.println("Frase: " + frase);
        System.out.println("Convertido a morse: " + morseFrase);

        // Ejemplo 6: Morse con doble espacio entre palabras
        String morseFraseCompleja = "... --- ...   .... . .-.. .--.";
        String textoFraseCompleja = convertor.convertir(morseFraseCompleja);
        System.out.println("Morse complejo: " + morseFraseCompleja);
        System.out.println("Convertido a texto natural: " + textoFraseCompleja);
    }
}
