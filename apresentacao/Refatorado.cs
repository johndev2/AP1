using System;

class Programa
{
    static void Main()
    {
        int primeiroNumero = 0;
        int segundoNumero = 0;
        int resultadoDeAdicao = 0;
        int resultadoDeSubtracao = 0;
        int resultadoDeMultiplicacao = 0;
        double resultadoDeDivisao = 0;

        Console.WriteLine("Digite dois números:");
        primeiroNumero = int.Parse(Console.ReadLine());
        segundoNumero = int.Parse(Console.ReadLine());

        resultadoDeAdicao = Somar(primeiroNumero, segundoNumero);
        resultadoDeSubtracao = Subtrair(primeiroNumero, segundoNumero);
        resultadoDeMultiplicacao = Multiplicar(primeiroNumero, segundoNumero);
        resultadoDeDivisao = Dividir(primeiroNumero, segundoNumero);

        Console.WriteLine($"Resultado da Adição: {resultadoDeAdicao}");
        Console.WriteLine($"Resultado da Subtração: {resultadoDeSubtracao}");
        Console.WriteLine($"Resultado da Multiplicação: {resultadoDeMultiplicacao}");
        Console.WriteLine($"Resultado da Divisão: {resultadoDeDivisao}");

        Console.ReadKey();
    }

    static int Somar(int a, int b)
    {
        return a + b;
    }

    static int Subtrair(int a, int b)
    {
        return a - b;
    }

    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static double Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Não é possível dividir por zero");
        }
        return (double)a / b;
    }
}
// Correções:

// Renomeado as variáveis para nomes descritivos.
// Adicionado declaração explícita de tipo de variáveis.
// Melhorou a formatação do código e adicionou indentação adequada.
// Substituiu a estrutura if-else aninhada por chamadas a métodos separados para cada operação matemática.
// Substituído o operador de divisão inteira por um operador de divisão real e adicionou uma verificação de divisão por zero.
// Essas refatorações ajudam a melhorar a legibilidade, a manutenibilidade e a eficiência do código.