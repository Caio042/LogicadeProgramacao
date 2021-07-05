using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDeRepetição
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            /*
            i.	Desenvolva um programa que receba um número inteiro digitado e apresente a tabuada deste número. 
            Utilize o loop for.  Sintaxe: 
            for (contador, limite, passo) { //codigo; } 
            */
            int numero;
            Console.WriteLine("Programa de tabuada\n\nDigite o número que quer ver na tabuada:");
            numero = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(numero + " x " + contador + " = " + numero * contador);
            }

            Console.ReadKey();
        }
    }
}
