using System;

public class Exercicio4
{
    public static void Main(string[] args)
    {
        int idade = 8;

        if (idade < 12)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (idade >= 12 && idade < 18)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else
        {
            Console.WriteLine("Você é um adulto.");
        }




    }
}