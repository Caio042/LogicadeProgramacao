using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocarPosicoes
{
    class TrocarPosicoes
    {
        static void Main(string[] args)
        {
            /*•	Declare um array de inteiros de 16 posições, 
             * preencha com números gerados aleatoriamente, 
             * troque os 8 primeiros valores pelos 8 últimos. 
             * Mostre o array original e o array final.*/

            //Declare um array de inteiros de 16 posições
            int[] array = new int[16];
            int[] arrayTrocado = new int[16];
            int[] auxiliar = new int[8];

            Random gerador = new Random();

            Console.WriteLine("Array original:");
            //preencha com números gerados aleatoriamente
            for (int i = 0; i < 16; i++)
            {
                array[i] = gerador.Next();
                Console.WriteLine(array[i]);
            }

            
            //troque os 8 primeiros valores pelos 8 últimos
            for (int i = 0; i < 8; i++)
            {
                auxiliar[i] = array[i];
                array[i] = array[i + 8];
                array[i + 8] = auxiliar[i];
            }

            //Mostre o array original e o array final.
            Console.WriteLine("\nTrocado os 8 primeiros pelos 8 últimos");
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}