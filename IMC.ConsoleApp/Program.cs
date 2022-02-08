using System;

namespace IMC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double imc, peso, altura;
            Console.WriteLine("Informe o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5) Console.WriteLine($"Seu Imc é {imc}, se encaixa abaixo do peso.");
            else if (imc >= 18.5 && imc <= 25) Console.WriteLine($"Seu Imc é {imc}, se encaixa Peso NOrmal.");
            else if (imc > 25 && imc <= 30) Console.WriteLine($"Seu Imc é {imc}, se encaixa Acima do peso.");
            else if (imc > 30) Console.WriteLine($"Seu Imc é {imc}, se encaixa Obeso");


        }
    }
}
