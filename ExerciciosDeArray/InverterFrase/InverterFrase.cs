using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterFrase
{
    class InverterFrase
    {
        static void Main(string[] args)
        {

            /*•	Faça um programa que receba uma frase digitada pelo usuário 
             * e exiba a mesma frase com cada palavra invertida. 
             * Exemplo: ETEC Albert Einstein – CETE treblA nietsniE  */

            Console.WriteLine("Escreva algo para ser invertido");

            string fraseRecebida = Console.ReadLine();

            //corta a frase em palavras
            string[] fraseCortada = fraseRecebida.Split();
            String fraseInvertida = "";

            //for que inverte tudo
            for (int i = 0; i < fraseCortada.Length; i++)
            {
                //array de cada palavara
                char[] arrayDaPalavra = fraseCortada[i].ToCharArray();

                //cada palavra invertida será armazenada aqui
                String palavraInvertida = "";

                //for que vai inverter cada palavra
                for (int y = arrayDaPalavra.Length - 1; y >= 0; y--)
                {
                    palavraInvertida += arrayDaPalavra[y];
                }

                //concatenando todas as palavras
                fraseInvertida += palavraInvertida + " ";
            }

            Console.WriteLine(fraseRecebida + " invertida é: " + fraseInvertida);

            Console.ReadKey();
        }
    }
}