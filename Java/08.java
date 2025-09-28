import java.util.HashMap;
import java.util.Locale;

public class Main {
    public static void main(String[] args) {
        // ORACIÓN DE PRUEBA: Incluye mayúsculas, minúsculas, puntuación y repeticiones.

        String oracionPrueba = "La casa azul, la casa verde. ¿Es esta la casa?";

        System.out.println("Oración de prueba: \"" + oracionPrueba + "\"");

        // LLAMADA A LA FUNCIÓN
        recuentoPalabras(oracionPrueba);

        System.out.println("\n--- OTROS EJEMPLOS ---");

        // Ejemplo 2: Más puntuación y más variaciones.
        String ejemplo2 = "Un Perro, dos Perros y TRES perros. ¡Perros!";
        System.out.println("Oración de prueba: \"" + ejemplo2 + "\"");
        recuentoPalabras(ejemplo2);
    }
    /**
     * Crea un programa que cuente cuantas veces se repite cada palabra
     * y que muestre el recuento final de todas ellas.
     * - Los signos de puntuación no forman parte de la palabra.
     * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
     * - No se pueden utilizar funciones propias del lenguaje que
     *   lo resuelvan automáticamente.
     **/
    public static void recuentoPalabras(String oracion){
        oracion = oracion.replaceAll("[^\\p{Alnum}]", " ");
        oracion = oracion.toLowerCase(Locale.ROOT);
        String[] palabras = oracion.split("\\s+");
        HashMap<String, Integer> recuento = new HashMap<>();
        for (String palabra : palabras){
            if (recuento.containsKey(palabra)){
                recuento.put(palabra, recuento.get(palabra) + 1);
            } else {
                recuento.put(palabra, 1);
            }
        }
        for (String key : recuento.keySet()){
            System.out.println("La palabra "+ key + " aparece "+ recuento.get(key) + " veces");
        }
    }
}
