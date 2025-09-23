#
# Crea una única función (importante que sólo sea una) que sea capaz
# de calcular y retornar el área de un polígono.
# - La función recibirá por parámetro sólo UN polígono a la vez.
# - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
# - Imprime el cálculo del área de un polígono de cada tipo.
#
from unidecode import unidecode # Para sacar los acentos

def areaPoligono(tipo, base, altura):
    tipo = unidecode(tipo)
    tipo = tipo.lower()
    if tipo == "triangulo":
        area = (base * altura) / 2
        return area 
    elif tipo == "cuadrado":
        area = altura * altura
        return area
    elif tipo == "rectangulo":
        area = base * altura
        return area 
    return "Elija un poligono (Triángulo, Cuadrado o Rectángulo)"

# Pruebas para verificar el cálculo del área

print("Área de triángulo (base=10, altura=5):", areaPoligono("Triángulo", 10, 5))
print("Área de cuadrado (lado=4):", areaPoligono("Cuadrado", 0, 4))  # base no se usa
print("Área de rectángulo (base=8, altura=3):", areaPoligono("Rectángulo", 8, 3))
print("Polígono no válido:", areaPoligono("Pentágono", 6, 2))
print("Con acento:", areaPoligono("Rectángulo", 5, 2))                                 # Esperado: 10
print("Mayúsculas y acento:", areaPoligono("CUÁDRADO", 0, 6))     