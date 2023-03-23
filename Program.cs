using System;

class Programa
{
    static void Main()
    {
        int c = 10;
        int d = 5;
        int x = 0;
        int y = 0;
        int z = 0;

        Console.WriteLine("Digite dois números:");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
            if (y > 0)
                z = c + d;
            else
                z = c - d;
        else if (y > 0)
            z = c * d;
        else
            z = c / d;

        Console.WriteLine("Resultado: " + z);

        Console.ReadKey();
    }
}
// Code Smells:

// Falta de nomes de variáveis descritivos.
// Falta de declaração explícita de tipo de variáveis.
// Má formatação do código e falta de indentação.
// Excesso de instruções condicionais aninhadas (estrutura if-else aninhada).
// Uso de operador de divisão inteira em vez de operador de divisão real.