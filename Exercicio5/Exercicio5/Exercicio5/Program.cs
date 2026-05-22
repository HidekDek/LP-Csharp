using System;

public class Exercicio4
{
    public static void Main(string[]args)
    {
        int idade = 45;
        bool ecasado = true;

        if (idade >= 65)
        {
            Console.WriteLine("Você é idoso.");
        }
        else if (idade < 65 && idade >= 18)
        {
            if (ecasado = false)
            {
                Console.WriteLine("Você é adulto e solteiro.");
            }
            else
            {
                Console.WriteLine("Você é adulto e casado.");
            }
        }

        else if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}