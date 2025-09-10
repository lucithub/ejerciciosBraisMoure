/*
     * Escribe una función que reciba dos palabras (String) y retorne
     * verdadero o falso (Bool) según sean o no anagramas.
     * - Un Anagrama consiste en formar una palabra reordenando TODAS
     *   las letras de otra palabra inicial.
     * - NO hace falta comprobar que ambas palabras existan.
     * - Dos palabras exactamente iguales no son anagrama.
*/
function isAnagrama(p1: string, p2: string): boolean{
    if (p1.length !== p2.length){
        return false;
    } else if (p1 === p2){
        return false;
    }
    let mapp1 = new Map<string, number>();
    let mapp2 = new Map<string, number>();
    for (let i = 0; i < p1.length; i++) {

    }
    return true;
}