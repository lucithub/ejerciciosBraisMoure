/*
     * Escribe una función que reciba dos palabras (String) y retorne
     * verdadero o falso (Bool) según sean o no anagramas.
     * - Un Anagrama consiste en formar una palabra reordenando TODAS
     *   las letras de otra palabra inicial.
     * - NO hace falta comprobar que ambas palabras existan.
     * - Dos palabras exactamente iguales no son anagrama.
*/
function isAnagram(p1, p2){
    p1 = p1.toLowerCase().replaceAll(" ", "");
    p2 = p2.toLowerCase().replaceAll(" ", "");
    if (p1.length !== p2.length || p1 === p2){
        return false;
    }
    let mapp1 = new Map();
    let mapp2 = new Map();
    for (let i = 0; i < p1.length; i++) {
        if (!mapp1.has(p1.charAt(i))){
            mapp1.set(p1.charAt(i), 1);
        } else {
            mapp1.set(p1.charAt(i), mapp1.get(p1.charAt(i)) + 1)
        }
    }
    for (let i = 0; i < p2.length; i++) {
        if (!mapp2.has(p2.charAt(i))){
            mapp2.set(p2.charAt(i), 1);
        } else {
            mapp2.set(p2.charAt(i), mapp2.get(p2.charAt(i)) + 1)
        }
    }
    for (let i = 0; i < p1.length; i++) {
        if (mapp2.get(p1.charAt(i)) === undefined){
            return false;
        }
        if (mapp1.get(p1.charAt(i)) !== mapp2.get(p1.charAt(i))){
            return false;
        }
    }
    return true;
}
/** PRUEBAS **/
console.log(isAnagram("listen", "silent"));        // true (caso básico)
console.log(isAnagram("Dormitory", "dirty room")); // true (ignora mayúsculas y espacios)
console.log(isAnagram("The eyes", "They see"));    // true (otro clásico con espacios)
console.log(isAnagram("Astronomer", "Moon starer"));// true

console.log(isAnagram("hello", "hello"));          // false (son iguales)
console.log(isAnagram("hello", "world"));          // false (no comparten letras suficientes)
console.log(isAnagram("abc", "abcd"));             // false (longitudes distintas)
console.log(isAnagram("Triangle", "Integral"));    // true (distinto orden, misma cantidad letras)

console.log(isAnagram("a b", "ab "));              // false (tras quitar espacios quedan iguales)
console.log(isAnagram("aabb", "bbaa"));            // true (con letras repetidas)
console.log(isAnagram("aabb", "bbaa "));           // true (si ignorás espacios)
