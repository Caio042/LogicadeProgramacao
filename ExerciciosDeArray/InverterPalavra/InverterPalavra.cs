using System;

namespace InverterPalavra
{
    class InverterPalavra
    {
        static void Main(string[] args)
        {
            /* Faça um programa que receba uma palavra e exiba a palavra digitada e a mesma palavra invertida. 
            Exemplo: Cristiane - enaitsirC 
            Converta a palavra recebida em um array de caracteres  - ToCharArray() -  e 
            percorra este array de trás para frente, pegando as letras e concatenando em uma variável String.
            */


            Console.WriteLine("Escreva algo para ser invertido");

            string palavraRecebida = Console.ReadLine();
            char[] palavra = palavraRecebida.ToCharArray();
            string palavraIntervida = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                palavraIntervida += palavra[i];
            }

            Console.WriteLine(palavraRecebida + " invertido é: " + palavraIntervida);
            Console.ReadKey();
        }
    }
}