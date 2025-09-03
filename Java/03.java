/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
public class Main {
    public static void main(String[] args) {
        Long n1 = 0L; Long n2 = 1L; Long suma = 0L;
        System.out.println("Numero 1 de Fibonacci: "+n1);
        System.out.println("Numero 2 de Fibonacci: "+n2);
        for (int i = 3; i < 51; i++) {
            suma = n1 + n2;
            System.out.println("Numero "+i+" de Fibonacci: "+suma);
            n1 = n2;
            n2 = suma;
        }
    }
}