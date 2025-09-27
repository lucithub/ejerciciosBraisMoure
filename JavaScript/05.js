/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */
/** FUNCION PARA SACAR ACENTOS **/
const quitarTildes = (texto) => {
    return texto
        .normalize("NFD") // Descompone los caracteres acentuados en su forma base
        .replace(/[\u0300-\u036f]/g, ""); // Elimina los diacríticos (la tilde)
};

function areaPoligono(poligono, base, altura){
    let area = 0;
    poligono = poligono.toLocaleLowerCase()
    poligono = quitarTildes(poligono)
    switch (poligono){
        case "triangulo":
            area = (base * altura) / 2
            break
        case "cuadrado":
            area = altura * altura
            break
        case "rectangulo":
            area = base * altura
            break
        default:
            return "Seleccione un poligono correcto. Los polígonos soportados son Triángulo, Cuadrado y Rectángulo."
    }
    return area
}
/** PRUEBAS **/
console.log(areaPoligono("triangulo", 10, 8)); // Debería retornar: 40
console.log(areaPoligono("Triángulo", 6, 4)); // Debería retornar: 12
console.log(areaPoligono("TRIANGULO", 5, 3)); // Debería retornar: 7.5
console.log(areaPoligono("cuadrado", 5, 5)); // Debería retornar: 25
console.log(areaPoligono("Cuadrado", 0, 7)); // Debería retornar: 49
console.log(areaPoligono("CUADRADO", 10, 3)); // Debería retornar: 9
console.log(areaPoligono("rectangulo", 8, 4)); // Debería retornar: 32
console.log(areaPoligono("Rectángulo", 12, 3)); // Debería retornar: 36
console.log(areaPoligono("RECTANGULO", 7, 6)); // Debería retornar: 42
console.log(areaPoligono("circulo", 5, 5)); // Debería retornar el mensaje de error
console.log(areaPoligono("hexagono", 3, 4)); // Debería retornar el mensaje de error
console.log(areaPoligono("", 2, 2)); // Debería retornar el mensaje de error
// Imprime el cálculo del área de un polígono de cada tipo (como pide el ejercicio)
console.log("Área del triángulo:", areaPoligono("triangulo", 10, 6));
console.log("Área del cuadrado:", areaPoligono("cuadrado", 0, 4));
console.log("Área del rectángulo:", areaPoligono("rectangulo", 8, 5));