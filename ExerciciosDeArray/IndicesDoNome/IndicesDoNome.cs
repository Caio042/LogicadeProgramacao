using System;

namespace IndicesDoNome
{
    class IndicesDoNome
    {
        static void Main(string[] args)
        {
            /*•	Leia um array de 52 posições contendo 
             * as letras do Alfabeto Maiúsculas seguida das letras minúsculas. 
             * Faça um programa que mostre a 
             * sequência numérica dos índices do array que forme seu nome. 
             * Armazene os índices em um array de inteiros chamado índices. 
             * O array de índices precisa ter o mesmo tamanho do nome. 
             * Exiba seu nome e abaixo os índices do array.*/

            char[] letras = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
                'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
                'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
                'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string nome = "Caio";
            char[] arrayNome = nome.ToCharArray();
            int[] indices = new int[arrayNome.Length];

            for (int i = 0; i < arrayNome.Length; i++)
            {
                for (int y = 0; y < letras.Length; y++)
                {
                    if (arrayNome[i].Equals(letras[y]))
                    {
                        indices[i] = y;
                    }
                }
            }
            Console.Write("Os indices de cada letra do nome " + nome + " são respectivamente: " + indices[0]);
            for (int z = 1; z < indices.Length; z++)
            {
                Console.Write(", " + indices[z]);
            }
            Console.ReadKey();
        }
    }
}
