using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNumeros
{
    class OrdenarNumeros
    {
        static void Main(string[] args)
        {
            /*Elaborar um programa que leia 3 valores inteiros digitados (representados pelas variáveis numA, numB e numC). 
             * O programa deverá apresentar os valores digitados em ordem crescente. 
             * Não esqueça que você precisará de uma variável auxiliar, para não perder os valores digitados pelo usuário.*/
            int numA, numB, numC, o1, o2, o3;

            Console.WriteLine("Digite um número");
            numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            numC = int.Parse(Console.ReadLine());

            if (numA < numB & numA < numC) // se o n1 o for menor
            {
                o1 = numA;
                if (numB < numC) // se o n2 for o segundo menor
                {
                    o2 = numB;
                    o3 = numC;
                }
                else // se o n3 for o segundo menor
                {
                    o2 = numC;
                    o3 = numB;
                }
            }
            else 
            {
                if (numB < numA & numB < numC) // se o n2 for o menor
                {
                    o1 = numB;
                    if (numA < numC) // se o n1 for o segundo menor
                    {
                        o2 = numA;
                        o3 = numC;
                    }
                    else // se o n3 for o terceiro menor
                    {
                        o2 = numC;
                        o3 = numA;
                    }
                }
                else // se o n3 for o menor
                {
                     o1 = numC;
                     if (numA < numB) // se o n1 for o segundo menor
                     {
                        o2 = numA;
                        o3 = numB;
                     }
                     else // se o n2 for o segundo menor
                     {
                        o2 = numB;
                        o3 = numA;
                     }
                }
            }
            Console.WriteLine("Os número digitados em ordem crescente são " + o1 + ", " + o2 + ", " + o3);
            Console.ReadKey();
        }
    }
}
