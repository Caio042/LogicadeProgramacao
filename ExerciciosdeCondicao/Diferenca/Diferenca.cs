using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diferenca
{
    class Diferenca
    {
        static void Main(string[] args)
        {
            //Desenvolva um programa que leia dois valores inteiros digitados pelo usuário, e apresente a diferença do maior pelo menor.
            int valor1, valor2, diferenca;

            Console.WriteLine("Digite um número");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                diferenca = valor1 - valor2;
            }
            else
            {
                diferenca = valor2 - valor1;
            }
            Console.WriteLine("A diferença entre os dois valores é " + diferenca);
            Console.ReadKey();
        }
    }
}
