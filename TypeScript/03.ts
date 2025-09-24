/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
console.log("El numero 1 de fibonacci es: 0");
console.log("El numero 2 de fibonacci es: 1");
let n1 = 0, n2 = 1, suma = 0;
for (let i = 3; i < 51; i++) {
    suma = n1 + n2;
    console.log("El numero "+ i +" de fibonacci es: "+ suma)
    n1 = n2;
    n2 = suma;
}