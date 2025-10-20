 #
 # Crea un programa que invierta el orden de una cadena de texto
 # sin usar funciones propias del lenguaje que lo hagan de forma automática.
 # - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 #
def invirtiendoCadenas(oracion):
    caracteres = []
    for i in range(len(oracion) - 1, -1, -1):
        caracteres.append(oracion[i])
    return ''.join(caracteres)

# PRUEBAS #
print(invirtiendoCadenas("Hola mundo"))
print(invirtiendoCadenas("Python"))
print(invirtiendoCadenas("12345"))
print(invirtiendoCadenas("A"))
print(invirtiendoCadenas(""))
print(invirtiendoCadenas("¿Cómo estás?"))
print(invirtiendoCadenas("   espacios   "))