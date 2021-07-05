using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomarValores
{
    class SomarValores
    {
        static void Main(string[] args)
        {
            /*
             i.	Desenvolver um programa que recebe um número inteiro 
                digitado e soma todos os números de 1 ate o numero 
                digitado e apresente o resultado abaixo. Utilize o loop for. 
                5! 1+2+3+4+5=15
            */
            int numero, soma = 0;
            Console.WriteLine("Somador de números\n\nDigite até quanto você quer que seja somado?");
            numero = int.Parse(Console.ReadLine());
            
            for (int cont = 1 ; cont <= numero; cont ++)
            {
                soma = soma + cont;
                Console.Write(cont);
                if (cont < numero) Console.Write(" + ");
            }
            Console.Write(" = " + soma);
            Console.ReadKey();
        }
    }
}
