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
            /*
            Faça um programa que o usuário escolha entre as opções 
            “1 – Par\n2 – Impar\n0-Sair”. 
            Exiba um número obtido randomicamente. 
            Se ele acertar, conte o ponto para o usuário, senão, ponto para o computador. 
            Exiba o placar a cada jogada. 
            Utilize o loop while
            */
            int escolha = 1, pntUsu = 0, pntCmp = 0, sorteio;
            Random gerador = new Random();
            Console.WriteLine("Jogo do par ou ímpar\nSortearemos um número, responda se é par ou ímpar");
            while (escolha > 0)
            {
                sorteio = gerador.Next(10);
                Console.WriteLine("\nO número: " + sorteio + " é par ou impar?\n" + "1 – Impar\n2 – Par\n0 - Sair");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 0) { break; }
                else if (escolha % 2 == 0 && sorteio % 2 == 0) // acertou, par
                {
                    pntUsu++;
                    Console.WriteLine("\nVocê acertou!!, o número " + sorteio + " é par");
                }
                else if (escolha % 2 !=0 && sorteio % 2 != 0) // acertou, impar
                {
                    pntUsu++;
                    Console.WriteLine("\nVocê acertou!!, o número " + sorteio + " é impar");
                }
                else if (sorteio % 2 == 0) // errou, par
                {
                    pntCmp++;
                    Console.WriteLine("\nVocê errou, o número " + sorteio + " é par, tente novamente");
                }
                else // errou, impar
                {
                    pntCmp++;
                    Console.WriteLine("\nVocê errou, o número " + sorteio + " é impar, tente novamente");

                }
                Console.WriteLine("\nJogador: " + pntUsu + " pontos\nComputador: " + pntCmp + " pontos");
            }
        }
    }
}
