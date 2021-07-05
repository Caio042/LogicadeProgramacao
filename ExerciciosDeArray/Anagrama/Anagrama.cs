using System;

namespace Anagrama
{
    class Anagrama
    {
        static void Main(string[] args)
        {
            /*•	Crie um programa que receba duas palavras e verifique se uma palavra é anagrama da outra. 
             * Anagramas são palavras formadas pelas mesmas letras arranjadas de forma diferente. 
             * Ex.: amor-Roma, América-Iracema, rato-ator.*/

            bool iguais = false;

            Console.WriteLine("Escreva duas palavras, e checaremos se são anagramas\nEscreva a primeira palavra:");
            //recebe a primeira palavra
            char[] palavra1 = Console.ReadLine().ToLower().ToCharArray();
            // recebe a segunda palavra
            Console.WriteLine("Escreva a segunda palavra:");
            char[] palavra2 = Console.ReadLine().ToLower().ToCharArray();
            

            //verifica se há caracteres iguais e os substitui os dois iguais por '0'
            for (int i = 0; i < palavra1.Length; i++)
            {
                for (int y = 0; y < palavra2.Length; y++)
                {
                    if (palavra1[i] == palavra2[y])
                    {
                        palavra1[i] = '0';
                        palavra2[y] = '0';
                        break;
                    }
                }
            }
            
            //checa se todas posição são iguais, se algum for diferente, a variavel fica false, e para de checar
            if (palavra1.Length.Equals(palavra2.Length))
            {
                for (int i = 0; i < palavra1.Length; i++)
                {
                    if (palavra1[i].Equals(palavra2[i]))
                    {
                        iguais = true;
                    }
                    else
                    {
                        iguais = false;
                        break;
                    }
                }
            }
            

            if (iguais)
            {
                Console.WriteLine("As duas palavras são anagramas");
            }
            else
            {
                Console.WriteLine("As duas palavras não são anagramas");
            }

            Console.ReadKey();
        }
    }
}