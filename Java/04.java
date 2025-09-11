/**
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 **/
public class Main {
    public static void main(String[] args) {
        for (int i = 2; i < 101; i++) {
            if (esPrimo(i)){
                System.out.println(i);
            }
        }
    }
    public static Boolean esPrimo(Integer numero){
        if (numero < 2) return false;
        for (int i = 2; i <= Math.sqrt(numero); i++) {
            if (numero % i == 0) {
                return false;
            }
        }
        return true;
    }
}