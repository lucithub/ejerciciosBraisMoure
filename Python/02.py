#
# Escribe una función que reciba dos palabras (String) y retorne
# verdadero o falso (Bool) según sean o no anagramas.
# - Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
# - NO hace falta comprobar que ambas palabras existan.
# - Dos palabras exactamente iguales no son anagrama.
#
from collections import Counter
def isAnagram(p1, p2):
    if p1 == p2:
        return False
    return Counter(p1) == Counter(p2)
# PRUEBAS
print(isAnagram("listen", "silent"))     # -> True
print(isAnagram("restful", "fluster"))   # -> True
print(isAnagram("apple", "papel"))       # -> True
print(isAnagram("rat", "car"))           # -> False
print(isAnagram("hello", "hello"))       # -> False (palabras idénticas)
print(isAnagram("a", "ab"))              # -> False
print(isAnagram("ab", "a"))              # -> False
print(isAnagram("night", "thing"))       # -> True
print(isAnagram("b", "b"))               # -> False
print(isAnagram("", ""))                 # -> False (cadenas vacías, idénticas)