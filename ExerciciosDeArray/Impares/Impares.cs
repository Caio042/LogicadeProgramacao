using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impares
{
    class Impares
    {
        static void Main(string[] args)
        {

            /*Declare um array de inteiros de 10 posições numéricas, 
             * preencha com os 10 primeiros números impares, 
             * gerados aleatoriamente, e exiba o array obtido.*/

            int[] inteiros = new int[10];
            Random gerador = new Random();

            Console.WriteLine("10 números impares:");

            //for para percorrer o array
            for (int i = 0; i < 10; i++ )
            {
                //gera de novo o número caso seja par
                do
                {
                    inteiros[i] = gerador.Next();
                } while (inteiros[i] % 2 == 0);

                //escreve na tela
                Console.WriteLine(inteiros[i]);
            }

        
            Console.ReadKey();
        }
    }
}
