#include <iostream>
#include <windows.h> // Inclua a biblioteca para usar SetConsoleTitle
#include "ClassPrint.h" // Certifique-se de incluir o arquivo de cabeçalho correspondente

int main() {
    // Define o título da janela do console
    SetConsoleTitle(L"C++ Sequencia de Fibonacci");

    int minimo, maximo;
    bool erro;

    while (true) {
        erro = false;

        std::cout << "Digite o valor minimo: ";
        if (!(std::cin >> minimo)) {
            std::cout << "Entrada inválida para o valor mínimo. Certifique-se de inserir um número inteiro." << std::endl;
            erro = true;
        }

        std::cout << "Digite o valor maximo: ";
        if (!(std::cin >> maximo) || maximo <= minimo) {
            std::cout << "Entrada inválida para o valor máximo. Certifique-se de inserir um número inteiro maior que o valor mínimo." << std::endl;
            erro = true;
        }

        if (!erro) {
            SequenciaDeFibonacci::ClassPrint::Print(minimo - 1, maximo);
        }
    }

    return 0;
}
