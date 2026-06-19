using System;
using System.Runtime.Serialization;

public class Exercicio11
{
    public static void Main(string[] args)
    {
        int i = 3;
        int multi = 1;
        while (i <= 30)
        {
            Console.WriteLine("3 x " + multi + " = " + i);
            i += 3;
            multi++;
        }
    }
}