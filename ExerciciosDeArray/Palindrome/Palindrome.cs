using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            /* Faça um programa que receba uma palavra digitada pelo usuário e verifique se essa palavra é palíndrome. 
             * Uma palavra palíndrome é aquela que pode ser lida tanto da direita para a esquerda quanto ao contrário. 
             * Exemplo: arara. */

            //metodo que checa se é um palindrome
            bool ChecarPalindrome(string palavra)
            {

                char[] palindrome = palavra.ToCharArray();
                int y = palavra.Length - 1;

                // olha metade e compara com a outra metade, se forem todos iguais retorna true, se algum for diferente retorna false
                // i percorre o array de forma crescente, y percorre de forma decrescente
                // assim, sempre checa a letra com a letra correspondente.
                for (int i = 0; i < palindrome.Length / 2; i++)
                {
                    if (palindrome[i] != palindrome[y])
                    {
                        return false;
                    }
                    y--;
                }
                return true;
            }

            Console.WriteLine("Escreva algo.\nVerificaremos se é um palíndrome");

            // recebe a palavra e trata.
            string palavraRecebida = Console.ReadLine().ToLower();

            //checa, exibindo a mensagem correspondente
            if (ChecarPalindrome(palavraRecebida))
            {
                Console.WriteLine("A palavra " + palavraRecebida + " é um palíndrome");
            }
            else
            {
                Console.WriteLine("A palavra " + palavraRecebida + " não é um palíndrome");
            }

            Console.ReadKey();

        }
    }
}