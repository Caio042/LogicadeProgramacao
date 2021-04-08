using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    class ParOuImpar
    {
        static void Main(string[] args)
        {
            // Elabore um programa que verifique se o numero digitado e par ou impar.
            int numero , resto;

            Console.WriteLine("Digite um número");
            numero = int.Parse (Console.ReadLine());
            resto = numero % 2; // Se o número for par não haverá resto de divisão por 2.
            if (resto == 0)
            {
                Console.WriteLine ("O número digitado é par");
            }
            else
            {
                Console.WriteLine("O número digitado é impar");
            }
            Console.ReadKey();
        }
    }
}
