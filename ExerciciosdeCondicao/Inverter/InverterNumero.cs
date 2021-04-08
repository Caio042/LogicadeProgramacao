using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverter
{
    class InverterNumero
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que receba um número digitado pelo usuário entre 100 e 999 e inverta os números. 
             * Por exemplo, se o usuário digitar 123, mostre: O inverso de 123 é 321. 
             * Utilize somente variáveis inteiras para inverter o número.*/
            int numero, centena, dezena, unidade;
            
            Console.WriteLine("Digite um número na faixa de 100 a 999 para ser invertido");
            numero = int.Parse(Console.ReadLine());
            centena = numero / 100;
            dezena = (numero % 100) / 10;
            unidade = numero % 10;
            Console.WriteLine("O inverso de " + numero + " é " + unidade + dezena + centena);
            Console.ReadKey();
        }
    }
}
