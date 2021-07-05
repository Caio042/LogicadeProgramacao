using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurarTodasOcorrencias
{
    class ProcurarTodasOcorrencias
    {
        static void Main(string[] args)
        {
            /*•	Declare um array de inteiros de 100 posições, 
             * preencha com números gerados aleatoriamente. 
             * Receba um valor digitado pelo usuário e exiba 
             * todos os índices do array onde ocorre o valor 
             * digitado ou se ele não foi encontrado. 
             * Exiba também o array*/

            //Declare um array de inteiros de 100 posições
            int[] array = new int[100];
            Random gerador = new Random();
            bool encontrado = false;

            //preencha com números gerados aleatoriamente
            for (int i = 0; i < 100; i++)
            {
                array[i] = gerador.Next();
            }

            Console.WriteLine("Digite um número");
            //receba um valor digitado pelo usuario
            int valor = int.Parse(Console.ReadLine());
            string indice = "";

            //pegando todas as vezes que o número ocorre
            for (int i = 0; i < 100; i++)
            {
                if (valor == array[i])
                {
                    indice += ", " + i;
                    encontrado = true;
                }
            }

            //exiba todos os índices do array onde ocorre o valor digitado ou se ele não foi encontrado.
            if (encontrado)
            {
                Console.WriteLine("O número " + valor + " foi encontrado nas posições" + indice + " do array");
            }
            else
            {
                Console.WriteLine("Número " + valor + " não encontrado no array");
            }

            //Exiba também o array
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}