# Escribe un programa que se encargue de comprobar si un número es o no primo.
# Hecho esto, imprime los números primos entre 1 y 100.
import math

def esPrimo(numero):
    if numero < 2:
      return False
    for i in range(2, math.isqrt(numero) + 1):
        if numero % i == 0:
            return False
    return True

for i in range(1, 101):
    if (esPrimo(i)):
      print(i)