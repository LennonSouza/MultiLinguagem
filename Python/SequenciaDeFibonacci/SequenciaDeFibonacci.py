while True:
    try:
        minimo = int(input("Valor minimo para comecar: ")) - 1
        maximo = int(input("Valor maximo para comecar: "))
        break
    except ValueError:
        print("Input invalido. Por Favor coloque um numero inteiro.")
        
param1, param2, resultado = 1, 1, 1

for x in range(maximo):
    
    param1 = param2
    param2 = resultado
    resultado = param1 + param2
    
    if minimo <= x <= maximo:
        print(str(param1) + " + " + str(param2) + " = " + str(resultado))