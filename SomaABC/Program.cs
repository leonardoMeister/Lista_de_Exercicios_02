using System;

namespace SomaABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Informe o valor A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor B: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o valor C: ");
            c = Convert.ToDouble(Console.ReadLine());

            double resultado = a + b;

            if (resultado > c) Console.WriteLine($"A soma de {a} com {b}, é maios que {c}.");
            else Console.WriteLine($"A soma de {a} com {b}, é menor que {c}.");

        }
    }
}
