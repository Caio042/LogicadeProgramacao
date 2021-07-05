using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeSoma
{
    class TesteDeSoma
    {
        static void Main(string[] args)
        {
           /*
            * i.	Desenvolva um programa que apresente um a expressão de 
            * soma de dois números obtidos randomicamente (de 1 a 10), 
            * caso o usuário digite a resposta errada, 
            * peça que ele tente novamente, 
            * se ele acertar, dê os parabéns. 
            * Conte quantas vezes ele acertou e apresente o 
            * percentual de acertos a cada jogada. 
            * Para sair, peça que ele digite 0. Utilize o loop while. 
            */
            int numeroUm, numeroDois, resposta = 1, contador = 0, acertos = 0;
            Random aleatorio = new Random();
            Console.WriteLine("Quiz de somar\n");

            while (resposta > 0)
            {
                numeroUm = aleatorio.Next(10);
                numeroDois = aleatorio.Next(10);

                Console.WriteLine("Qual o resultado da soma de " + numeroUm + " + " + numeroDois + "? " + "Para sair digite 0");
                resposta = int.Parse(Console.ReadLine());
                contador++;
                if (resposta == 0)
                {
                    break;
                }
                else if (resposta == numeroUm + numeroDois)
                {
                    acertos++;
                    Console.WriteLine("Parabéns! Você acertou!\n" + numeroUm + " + " + numeroDois + " = " + (numeroUm + numeroDois));
                }
                else
                {
                    Console.WriteLine("Você errou\n" + numeroUm + " + " + numeroDois + " = " + (numeroUm + numeroDois) + "\ntente novamente");
                }
                Console.WriteLine("Porcentagem de acerto: " +  ((double) acertos / contador * 100) + "%\n");
            }
        }
    }
}
