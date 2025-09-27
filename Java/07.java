import java.util.Scanner;

/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingrese una cadena: ");
        String cadena = scanner.nextLine();
        StringBuilder cadenaNueva = new StringBuilder();
        int ii = cadena.length() - 1;
        for (int i = 0; i < cadena.length(); i++) {
            cadenaNueva.append(cadena.charAt(ii));
            ii--;
        }
        System.out.println(cadenaNueva);
    }
}
