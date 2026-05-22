using System;

public class Exercicio3
{
    public static void Main(string[] args)
    {
        int num1 = 42;
        int num2 = 27;

        if (num1 > num2)
        {
            Console.WriteLine("O número maior é: " + num1);
        }
        else if (num2 > num1)
        {
            Console.WriteLine("O número maior é: " + num2);
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }
}