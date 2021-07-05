using System;

namespace MaiorGanha
{
    class MaiorGanha
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa que exiba um número de 1 a 100 obtido randomicamente para o usuário
            e pergunte se ele quer apostar. 
            Se sim, gere outro número obtido randomicamente. 
            Se o número recebido pelo usuário for maior, pontue o usuário, 
            se o número apresentado para o computador for maior, pontue o computador, 
            se os números forem iguais, não pontue ninguém. 
            Exiba o placar a cada jogada. Utilize a o loop do while
            */
            int n1, n2, contador = 0, pntUsu = 0, pntCmp = 0, escolha;
            Random gerador = new Random();
            
            Console.WriteLine("Jogo do maior ganha\nSeu número e sorteado, se resolver apostar o número do computador é sorteado e o maior ganha.");

            do
            {
                n1 = gerador.Next(100);
                Console.WriteLine("Seu número é " + n1 + " Apostar? (2-sim / 1-não / 0-sair)");
                escolha = int.Parse(Console.ReadLine());
                if (escolha == 2)
                {
                    n2 = gerador.Next(100);
                    Console.WriteLine("Número do computador: " + n2);
                    if (n1 > n2)
                    {
                        pntUsu++;
                        Console.WriteLine("Parabéns, você ganhou :)");
                    }
                    else if (n1 == n2)
                    {
                        Console.WriteLine("Empatou :/");
                    }
                    else
                    {
                        pntCmp++;
                        Console.WriteLine("Você perdeu :(");
                    }
                    contador++;
                    Console.WriteLine("\nJogadas: " + contador + "\n\nPontuação:\nJogador: " + pntUsu + " pontos\nComputador: " + pntCmp + " pontos\n");
                }
            } while (escolha > 0);
        }
    }
}
