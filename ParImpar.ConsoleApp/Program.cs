using System;

namespace ParImpar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) Console.WriteLine("Numero Par");
            else Console.WriteLine("Numero Impar");

            Console.ReadLine();
        }
    }
}
