using System;

public class Exercicio1
{
    public static void Main(string[]args)
    {
       int num1 = 67;
       int num2 = 20;

        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicacao = num1 * num2;
        int divisao = num1 / num2;
        int resto = num1 % num2;

        Console.WriteLine("-==OPERAÇÕES COM OS NUMEROS==-");
        Console.WriteLine("67 e 20");
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);
        Console.WriteLine("Divisão: " + divisao);
        Console.WriteLine("resto: " + resto);
    }
}
