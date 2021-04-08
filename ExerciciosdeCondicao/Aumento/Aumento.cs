using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aumento
{
    class Aumento
    {
        static void Main(string[] args)
        {
			/*Uma empresa decidiu dar reajuste a seus funcionários de acordo com os seguintes critérios:
				o 10% para os funcionários que recebam um salario inferior a 1000 reais (<1000)
				o 8% para os funcionários que recebam até 2000 reais (<=2000)
				o 6% para os funcionários que recebam até 3500 reais (<=3500)
				o 4% para os funcionários que recebam até 5000 reais (<=5000)
				o 2% para os demais.

			Desenvolva um programa que efetue esse calculo e apresente o resultado:
				Salário anterior = <salario>
				Aumento = <valor do aumento>
				Salário atual = <salário atual>*/
			decimal salario, reajuste, novoSalario;

			Console.Write("Programa de aumento de salário\n\nDigite o Salário do funcionário (utilize vírgula para separar os reais dos centavos)\nR$");
			salario = decimal.Parse(Console.ReadLine());


			if (salario < 1000m)
			{
				reajuste = salario * 0.10m;
			}
			else if (salario <= 2000.00m)
			{

				reajuste = salario * 0.08m;
			}
			else if (salario <= 3500.00m)
			{
				reajuste = salario * 0.06m;
			}
			else if (salario <= 5000.00m)
			{
				reajuste = salario * 0.04m;
			}
			else
			{
				reajuste = salario * 0.02m;
			}
			novoSalario = salario + reajuste;
			novoSalario = Math.Round(novoSalario, 2);
			salario = Math.Round(salario, 2);
			reajuste = Math.Round(reajuste, 2);
			Console.WriteLine("Salário anterior: R$" + salario + "\nValor do aumento: R$" + reajuste + "\nValor do novo salário: R$" + novoSalario);
			Console.ReadKey();
		}
    }
}
