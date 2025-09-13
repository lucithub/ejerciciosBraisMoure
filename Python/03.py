 #
 # Escribe un programa que imprima los 50 primeros números de la sucesión
 # de Fibonacci empezando en 0.
 # - La serie Fibonacci se compone por una sucesión de números en
 #   la que el siguiente siempre es la suma de los dos anteriores.
 #   0, 1, 1, 2, 3, 5, 8, 13...
 #
 print("El numero 1 de Fibonacci es: 0")
 print("El numero 2 de Fibonacci es: 1")
 int suma = 0
 int n1 = 0
 int n2 = 1
 for i in range(3, 50):
     suma = n1 + n2
     print("El numero " + i +" de Fibonacci es: "+ suma)
     n1 = n2 
     n2 = suma