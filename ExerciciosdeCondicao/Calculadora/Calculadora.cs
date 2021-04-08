using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que receba 2 números digitados pelo usuário, e armazene em duas variáveis do tipo real. Após receber os 2 números, apresente o seguinte menu:
                1 – adição / 2 – subtração / 3 – multiplicação / 4 – divisão / 5 – resto da divisão

            Depois que o usuário escolher a opção, efetue a operação escolhida pelo usuário, sempre o primeiro pelo segundo, 
            por exemplo: Se o usuário digitar 10 e 5 e escolher subtração, subtraia 10 – 5. Exiba ao final o cálculo, da seguinte forma:
                10 – 5 = 5

            Utilize o comando caso:
                escolha operacao
                caso 1
                caso 2
                ...
                outrocaso
                escreval ("Opção Inválida")
                fimescolha*/


            //Adicionei um laço de repetição ao exercício para poder utilizar a calculadora de novo sem fechar.


            decimal numero1, numero2, resultado;
            int operador;
            char continuar;
            do
            {
                Console .WriteLine("Calculadora simples\nDigite o primeiro número da operação");
                numero1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número da operação");
                numero2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número correspondente a operação que dejesa realizar?\n1 - adição / 2 - subtração / 3 - multiplicação / 4 - divisão / 5 - resto da divisão");
                operador = int.Parse(Console.ReadLine());
                switch (operador)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine(numero1 + " - " + numero2 + " = " + resultado);
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine(numero1 + " * " + numero2 + " = " + resultado);
                        break;
                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine(numero1 + " / " + numero2 + " = " + resultado);
                        break;
                    case 5:
                        resultado = numero1 % numero2;
                        Console.WriteLine(numero1 + " % " + numero2 + " = " + resultado);
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }
                Console.WriteLine("deseja fazer outra operação? (Y/N)");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (continuar == 'y' | continuar == 'Y');
            Console.ReadKey();
        }
    }
}
