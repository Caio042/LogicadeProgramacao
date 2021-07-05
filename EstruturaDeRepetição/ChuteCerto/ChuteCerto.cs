using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuteCerto
{
    class ChuteCerto
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que receba um número (de 1 a 10) digitado pelo usuário. 
            Gere um número randomicamente. 
            Se número gerado for igual ao número informado pelo usuário, dê os parabéns e some 1 ponto. 
            Senão, some 1 ponto para o computador. Exiba o placar a cada jogada. 
            Para sair peça que ele digite 0.
             */
            int escolha, pntUsu = 0, pntCmp = 0;
            Random gerador = new Random();
            Console.WriteLine("Jogo do Chute Certo\nSortearemos um número, tente acertar qual");
            do
            {
                Console.WriteLine("\nSorteando número...\nQual número de 1 a 10 você acha que foi sorteado?\nPara sair digite 0");
                int sorteio = gerador.Next(1, 10);
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 0)
                {
                    break;
                }
                else if (escolha == sorteio)
                {
                    pntUsu++;
                    Console.WriteLine("\nParabéns, você acertou, o número sorteado foi: " + sorteio);
                }
                else
                {
                    pntCmp++;
                    Console.WriteLine("\nVocê errou, o número sorteado foi: " + sorteio);
                }
                Console.WriteLine("\nJogador: " + pntUsu + " pontos\n" + "Computador: " + pntCmp + " pontos");
            }
            while (escolha > 0);
        }
    }
}
