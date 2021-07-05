using System;

namespace ProcurarPrimeiraOcorrencia
{
    class ProcurarPrimeiraOcorrencia
    {
        static void Main(string[] args)
        {
            /*•	Declare um array de inteiros de 20 posições, 
             * preencha com números gerados aleatoriamente. 
             * Receba um valor digitado pelo usuário e 
             * exiba a primeira posição do array onde este valor 
             * foi encontrado ou se ele não foi encontrado e o array.*/

            //Declare um array de inteiros de 20 posições
            int[] array = new int[20];
            Random gerador = new Random();
            bool encontrado = false;

            //preencha com números gerados aleatoriamente
            for (int i = 0; i < 20; i++)
            {
                array[i] = gerador.Next();
            }

            Console.WriteLine("Digite um número");
            //receba um valor digitado pelo usuario
            int valor = int.Parse(Console.ReadLine());

            // checa todos os números do array, se encontrar, mostra onde foi encontrado e para de checar
            for (int i = 0; i < 20; i++)
            {
                if (valor == array[i])
                {
                    Console.WriteLine("O número " + valor + " foi encontrado na posição " + i + " do array");
                    encontrado = true;
                    break;
                }
            }
            // se não achar a variavel fica como false, e exibe na tela que não foi encontrado.
            if (!encontrado)
            {
                Console.WriteLine("Número não encontrado no array");
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}