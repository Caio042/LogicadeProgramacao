using System;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {

            /*•	Crie um programa que receba por parâmetro um número inteiro de chamado 
            * índice e exiba o valor do número de Fibonacci correspondente. 
            * Os números de Fibonacci n1, n2, n3... são definidos da seguinte forma:
            * N[0] = 0, n[1] = 1, n[i] = n[i – 1] + n[i – 2], sendo i>=2
            */

            //mensagem ao usuario
            Console.WriteLine("Qual o número de Fibonacci desejado?");

            //recebimento do tamanho do array
            int f = int.Parse(Console.ReadLine());
            if (f < 1)
            {
                Console.WriteLine("Número invalido");
                Console.ReadKey();
            }
            else
            {
                //declaração do array com o indice indicado pelo usuario
                int[] n = new int[f];
                f--;

                //definindo os primeiros números de Fibonacci
                if (f >= 0)
                    n[0] = 0;
                if (f >= 1)
                    n[1] = 1;

                //definindo os outros
                if (f >= 2)
                {
                    for (int i = 2; i <
                        n.Length; i++)
                    {
                        n[i] = ((n[i - 1]) + (n[i - 2]));
                    }
                }
                //exibição do calculo final
                Console.WriteLine("O número " + (f + 1) + " de Fibonacci é " + n[f]);
                Console.ReadKey();
            }
        }
    }
}
