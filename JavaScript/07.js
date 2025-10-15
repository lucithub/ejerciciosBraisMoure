/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */
function invirtiendoCadenas(string){
    let cadenaNueva = "";
    for (let i = string.length; i > 0; i--) {
        cadenaNueva = cadenaNueva + string.charAt(i - 1);
    }
    return cadenaNueva
}

/** PRUEBAS **/
// Asegúrate de que tu función esté definida antes de estas llamadas
// function invirtiendoCadenas(string){ ... }

// 1. Caso estándar con espacios (el ejemplo del enunciado)
console.log("--- Caso Estándar ---");
console.log('Original: "Hola mundo"');
console.log('Resultado: "' + invirtiendoCadenas("Hola mundo") + '"'); // Esperado: "odnum aloH"

// 2. Una sola palabra y mayúsculas
console.log("\n--- Una Sola Palabra ---");
console.log('Original: "Funcionando"');
console.log('Resultado: "' + invirtiendoCadenas("Funcionando") + '"'); // Esperado: "odnanoinucF"

// 3. Cadena con números y símbolos
console.log("\n--- Números y Símbolos ---");
console.log('Original: "2025!"');
console.log('Resultado: "' + invirtiendoCadenas("2025!") + '"'); // Esperado: "!5202"

// 4. Cadena vacía (caso límite)
console.log("\n--- Cadena Vacía ---");
console.log('Original: ""');
console.log('Resultado: "' + invirtiendoCadenas("") + '"'); // Esperado: ""

// 5. Frase con puntuación
console.log("\n--- Frase Larga ---");
console.log('Original: "¿Qué tal?"');
console.log('Resultado: "' + invirtiendoCadenas("¿Qué tal?") + '"'); // Esperado: "?lat éuQ¿"