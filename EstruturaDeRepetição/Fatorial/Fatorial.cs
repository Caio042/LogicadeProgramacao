using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Fatorial
    {
        static void Main(string[] args)
        {
            /*
             i.	Desenvolver um programa que recebe um número inteiro digitado 
            e multiplique todos os números de 1 ate o numero digitado 
            e apresente o resultado abaixo. Utilize o loop for. 
                5! 1*2*3*4*5=120
            */
            int numero, fator = 1;
            Console.WriteLine("Somador de números\n\nDigite até quanto você quer que seja fatorado?");
            numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {

                for (int cont = 1; cont <= numero; cont++)
                {
                    fator = fator * cont;
                    Console.Write(cont);
                    if (cont < numero) Console.Write(" x ");
                }
                Console.Write(" = " + fator);
            }
            else 
            { 
                Console.WriteLine("Digite um número maior que 0"); 
            }
            Console.ReadKey();
        }
    }
}
