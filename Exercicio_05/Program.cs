using System;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             • Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais 
               deverá se somar os dois, caso contrário multiplique A por B.
               Ao final de qualquer um dos cálculos deve-se atribuir o resultado para 
               uma variável C e mostrar seu conteúdo na tela.
             */

            double a, b;
            
            Console.WriteLine("Informe o primeiro valor: ");
            a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Informe o primeiro valor: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a ==b)
            {
                Console.WriteLine($"Valores iguais, soma = {a + b}");
            }else Console.WriteLine($"Valores diferentes, multiplicacao = {a * b}");
        }
    }
}
