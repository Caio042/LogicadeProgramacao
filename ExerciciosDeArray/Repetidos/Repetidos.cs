using System;

namespace Repetidos
{
    class Repetidos
    {
        static void Main(string[] args)
        {
            /*•	Declare um array de 100 posições, 
             * preencha e verifique se existem valores iguais. 
             * Escreva os valores que se repetem e quantas vezes ocorre a repetição.*/


            //Declare um array de inteiros de 100 posições
            int[] array = new int[100];
            Random gerador = new Random();
            string repetidos = "";


            //preencha com números gerados aleatoriamente
            for (int i = 0; i < 100; i++)
            {
                array[i] = gerador.Next();
                Console.WriteLine(array[i]);
            }


            for (int i = 0; i < 100; i++)
            {
                //se o valor for -1 nem faz a operação
                if (array[i] == -1)
                    continue;

                //marca todos os números já checados mudando o valor pra -1
                int auxiliar = array[i];
                array[i] = -1;
                int repeticoes = 0;

                for (int y = 0; y < 100; y++)
                {
                    //se for igual contabiliza e marca os já checados com -1
                    if (auxiliar.Equals(array[y]))
                    {
                        repeticoes++;
                        array[y] = -1;
                    }
                }

                // caso tenha se repetido, contabiliza o número repetido e quantas vezes se repetiu na string
                if (repeticoes > 0)
                {
                    repetidos += "O número " + auxiliar + " se repetiu " + repeticoes + " vezes\n";
                }
            }

            //mostra na tela quantas repetições houve caso tenha havido alguma.
            if (repetidos == "")
            {
                Console.WriteLine("Nenhum número se repetiu");
            }
            else
            {
                Console.WriteLine(repetidos);
            }

            Console.ReadKey();
        }
    }
}