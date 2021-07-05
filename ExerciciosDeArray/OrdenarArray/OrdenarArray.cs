using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que gere e armazene em um 
             * array 10 valores gerados randomicamente – 
             * e os apresente na ordem em que foram gerados. 
             * Ordene os valores e apresente os valores 
             * ordenados do menor para o maior. */

            int[] arrayOrdenado = new int[10];
            Random gerador = new Random();

            Console.WriteLine("Desordenado:");
            //adicionar 10 valores aleatórios no array e mostrar na tela
            for (int i = 0; i < 10; i++)
            {
                arrayOrdenado[i] = gerador.Next();
                Console.WriteLine(arrayOrdenado[i]);
            }

            //for para repetir o for
            for (int i = 0; i < 10; i++)
            {
                //for para checar qual o menor e ordenar
                for (int y = 1; y < 10; y++)
                {
                    if (arrayOrdenado[y] < arrayOrdenado[y - 1])
                    {
                        int auxiliar = arrayOrdenado[y];
                        arrayOrdenado[y] = arrayOrdenado[y - 1];
                        arrayOrdenado[y - 1] = auxiliar;
                    }
                }
            }

            // mostrar ordenado
            Console.WriteLine("\nOrdenado:");
            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine(arrayOrdenado[z]);
            }
            Console.ReadKey();
        }
    }
}