using System;

namespace MostrarValoresOrdem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Informe o primeiro valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor: ");
            c = Convert.ToDouble(Console.ReadLine());



            if (a > b && a > c)
            {
                Console.WriteLine($"O valor A: {a}, é o maior.");
                if (b > c)
                {
                    Console.WriteLine($"seguido valor B: {b}, é o maior.");
                    Console.WriteLine($"Por ultimo valor C: {c}.");
                }
                else
                {
                    Console.WriteLine($"seguido valor C: {c}, é o maior.");
                    Console.WriteLine($"Por ultimo valor B: {b}.");
                }
                       ;
            }

            else if (b > c)
            {
                Console.WriteLine($"O valor B: {b}, é o maior.");
                if (a > c)
                {
                    Console.WriteLine($"seguido valor A: {a}, é o maior.");
                    Console.WriteLine($"Por ultimo valor C: {c}.");
                }
                else
                {
                    Console.WriteLine($"seguido valor C: {c}, é o maior.");
                    Console.WriteLine($"Por ultimo valor A: {a}.");
                }
            }
            else
            {
                Console.WriteLine($"O valor C: {c}, é o maior.");
                if (a > b)
                {
                    Console.WriteLine($"seguido valor A: {a}, é o maior.");
                    Console.WriteLine($"Por ultimo valor B: {b}.");
                }
                else
                {
                    Console.WriteLine($"seguido valor B: {b}, é o maior.");
                    Console.WriteLine($"Por ultimo valor A: {a}.");
                }
            }



        }
    }
}
