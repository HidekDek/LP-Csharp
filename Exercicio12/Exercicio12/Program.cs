using System;

public class Exercicio11
{
    public static void Main(string[] args)
    {
        int i = 0;
        int somaFinal = 0;

        for (i = 0; somaFinal <= 100; i++)
        {
            somaFinal += i;
            Console.WriteLine(somaFinal);
        }
        Console.WriteLine("O ultimo valor adicionado é: " + i);
    }
}    