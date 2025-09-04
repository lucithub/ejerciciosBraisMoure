/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
let n1 = 0; let n2 = 1; let suma = 0;
console.log("Numero 1 de Fibonacci: "+n1);
console.log("Numero 2 de Fibonacci: "+n2);
for (let i = 3; i < 51; i++) {
    suma = n1 + n2;
    console.log("Numero "+i+" de Fibonacci: "+suma);
    n1 = n2;
    n2 = suma;
}