using System;

namespace Media
{
    class Media
    {
        static void Main(string[] args)
        {
            /*•	Faça um programa que receba 4 notas digitadas pelo usuário e calcule a média.*/

            //Array contendo as notas
            double[] notas = new double[4];

            //for para iterar o array
            for (int i = 0; i < notas.Length; i++)
            {
                // pegando cada nota e adicionando a uma posição do array
                Console.WriteLine("Digite a " + (i + 1) + "ª nota");
                notas[i] = double.Parse(Console.ReadLine());
            }

            //calculo da media
            double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            //exibição do resultado
            Console.WriteLine("As notas foram \n" + notas[0] + "\n" + notas[1] + "\n" + notas[2] + "\n" + notas[3] + "\nMédia = " + media);
            Console.ReadKey();
        }
    }
}
