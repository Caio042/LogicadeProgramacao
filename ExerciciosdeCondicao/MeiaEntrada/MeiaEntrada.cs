using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiaEntrada
{
    class MeiaEntrada
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que calcule meia entrada para menores de 12 anos, maiores de 65 anos ou estudantes. 
             * Receba os parâmetros do usuário. Idade (inteiro), estudante (lógico). 
             * Faça um único se para testar todas as condições de uma única vez. 
             * O valor da entrada é R$ 20,00. 
             * Exibir o valor da entrada a ser pago pelo cliente*/
            int idade;
            bool estudante;

            Console.WriteLine("Cinema da cidade \n");
            Console.Write ("Para entrar e comprar um ingresso me diga sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine ("É estudante? (true/false)");
            estudante = bool.Parse(Console.ReadLine());

            if (idade <= 12 || idade >= 65 || estudante)
            {
                Console.WriteLine("A meia-entrada é R$ 10,00 \nBom filme");
            }
            else
            {
                Console.WriteLine("O ingresso é R$20,00 \nBom filme");
            }
            Console.ReadKey();
        }
    }
}
