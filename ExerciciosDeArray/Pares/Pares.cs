using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares
{
    class Pares
    {
        static void Main(string[] args)
        {
            /*•	Declare um array de inteiros de 40 posições, 
             * preencha com números aleatórios. 
             * Contar e exibir quantos valores pares ele 
             * possui e exibir o array gerado.*/

            //Declare um array de inteiros de 40 posições,
            int[] inteiros = new int[40];
            Random gerador = new Random();
            int contador = 0;

            Console.WriteLine("40 números:");

            //for para percorrer o array
            for (int i = 0; i < 40; i++)
            {
                //checa se é par e conta
                inteiros[i] = gerador.Next();
                if (inteiros[i] % 2 == 0)
                {
                    contador++;
                }
                // escreve o array na tela
                Console.WriteLine(inteiros[i]);
            }

            // mostra quantos pares teve
            Console.WriteLine("O array contém " + contador + " números pares");

            Console.ReadKey();
        }
    }
}