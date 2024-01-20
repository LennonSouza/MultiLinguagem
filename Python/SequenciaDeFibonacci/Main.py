import ClassPrint
          
while True:
    try:
        minimo = int(input("Valor minimo para comecar: ")) - 1
        maximo = int(input("Valor maximo para comecar: "))
        break
    except ValueError:
        print("Input invalido. Por Favor coloque um numero inteiro.")
        
            
ClassPrint.Print(minimo, maximo)