#include <iostream>
#include <windows.h> // Inclua a biblioteca para usar SetConsoleTitle
#include "ClassPrint.h" // Certifique-se de incluir o arquivo de cabe�alho correspondente

int main() {
    // Define o t�tulo da janela do console
    SetConsoleTitle(L"C++ Sequencia de Fibonacci");

    int minimo, maximo;
    bool erro;

    while (true) {
        erro = false;

        std::cout << "Digite o valor minimo: ";
        if (!(std::cin >> minimo)) {
            std::cout << "Entrada inv�lida para o valor m�nimo. Certifique-se de inserir um n�mero inteiro." << std::endl;
            erro = true;
        }

        std::cout << "Digite o valor maximo: ";
        if (!(std::cin >> maximo) || maximo <= minimo) {
            std::cout << "Entrada inv�lida para o valor m�ximo. Certifique-se de inserir um n�mero inteiro maior que o valor m�nimo." << std::endl;
            erro = true;
        }

        if (!erro) {
            SequenciaDeFibonacci::ClassPrint::Print(minimo - 1, maximo);
        }
    }

    return 0;
}
