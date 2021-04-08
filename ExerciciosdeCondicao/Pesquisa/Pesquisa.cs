using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa
{
    class Pesquisa
    {
        static void Main(string[] args)
        {
			/*Desenvolva um programa que teste responda se a pessoa está apta para participar da pesquisa. 
			 * Uma empresa quer testar a satisfação dos clientes com um produto lançado recentemente no mercado. 
			 * Os consumidores entrevistados deverão ser do sexo masculino, idade entre 20 e 25 anos, da classe A ou B, 
			 * nível superior, que tenham adquirido o produto há mais de 6 meses e menos de 1 ano. 
			 * Teste as informações e exiba “Apto” ou “Fora da faixa pesquisada”. 
			 * Crie Se’s encadeados e passe para a próxima pergunta somente se ele continuar apto.*/
			char genero, classe, ensinoSuperior;
			int idade, aquisicao;
			bool inapto = true;

			Console.WriteLine("Pesquisa da empresa 'x' e do produto 'y'\n\nPara participar confirmaremos se está apto\nQual o seu gênero? (M/F)");
			genero = char.Parse(Console.ReadLine());
			if (genero == 'M' || genero == 'm')
			{
				Console.WriteLine("Qual a sua idade?");
				idade = int.Parse(Console.ReadLine());
				if (idade >= 20 && idade <= 25)
				{
					Console.WriteLine("Qual a sua classe social? (A/B/C/D/E)");
					classe = char.Parse(Console.ReadLine());

					if (classe == 'A' || classe == 'a' || classe == 'B' || classe == 'b')
					{

						Console.WriteLine("Concluiu o ensino superior? (S/N)");
						ensinoSuperior = char.Parse(Console.ReadLine());

						if (ensinoSuperior == 's' || ensinoSuperior == 'S')
						{
							Console.WriteLine("Há quantos meses adquiriu o produto?");
							aquisicao = int.Parse(Console.ReadLine());

							if (aquisicao < 13 && aquisicao > 5)
							{
								inapto = false;
								Console.WriteLine("Está apto a participar da pesquisa!");
							}
						}
					}
				}
			}
			if (inapto)
			{
				Console.WriteLine("Desculpe, você está fora da nossa faixa pesquisada");
			}
			Console.ReadKey();
		}
    }
}
