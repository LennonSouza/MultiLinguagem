import math

a = int(input("Valor de a: "))
b = int(input("Valor de b: "))
c = int(input("Valor de c: "))

delta = (b ** 2) - 4 * a * c

resultado1 = (-b + math.sqrt(delta))/(2 *a)
print (resultado1)

resultado2 = (-b - math.sqrt(delta))/(2 *a)
print (resultado2)