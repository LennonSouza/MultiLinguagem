param1 = 1; param2 = 1; resultado =1;

minimo = int(input("Valor minimo para comecar: ")) -1
maximo = int(input("Valor maximo para comecar: "))

for x in range(maximo):
    
    param1 = param2
    param2 = resultado
    resultado = param1 + param2
    
    if x >= minimo and x <= maximo:
        print(str(param1) + " + " + str(param2) + " = " + str(resultado))