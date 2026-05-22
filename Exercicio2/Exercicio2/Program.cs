using System;

public class Exercicio2
{
    public static void Main(string[] args)
    {
        double raio = 9;
        const double PI = 3.14;

        double area = raio * raio * PI;

        Console.WriteLine("O raio do círculo é: " + raio);
        Console.WriteLine("Logo, a área do círculo é: " + area+"m2");
    }
}