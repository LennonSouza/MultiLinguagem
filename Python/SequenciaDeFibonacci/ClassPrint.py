def PrintFibonacci(minimo, maximo):
        
    param1, param2, resultado = 1, 1, 1

    for x in range(maximo):
    
        param1 = param2
        param2 = resultado
        resultado = param1 + param2
    
        if minimo <= x <= maximo:
            print(f"{param1} + {param2} = {resultado}")