using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParIdeal
{
    class ParIdeal
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que sugira uma pessoa como sendo o par ideal. Para faça alguns testes:
                · Apresente 5 faixas de salário
                · Entre 1 a 10 salários mínimos.
                · Apresente 6 escolaridades:
                    · Não Alfabetizado, Fundamental, Médio, Superior, Mestrado, Doutorado
                · Apresente as 4 estações do ano
                    · primavera, verão, outono, inverno
                · Apresente 5 opções de viagem:
                    · cidade, campo, praia, radical, cruzeiro
                · Apresente 5 cores:
                    · preto, azul, verde, vermelho, branco.
                · Apresente os gêneros:
                    · F, M.
                Ao final, apresente como sugestão de par ideal o nome de uma pessoa qualquer. 
                O programa deve apresentar nomes diferentes caso a pessoa mude as escolhas. 
                Vá pontuando conforme as escolhas. 
                Cada opção possui um valor, por exemplo, a faixa 1 de salário vale 1, a faixa 2 vale 2 e assim por diante. 
                O menor valor que a pessoa vai obter, escolhendo sempre as opções 1 será 5 pontos. 
                O gênero não conta ponto. Ao mostrar o par ideal, veja se o gênero é F ou M.
                Você vai precisar de 25 nomes para cada gênero. */
            
            string[ , ] nomes = new string [2, 21] { {"Tati Quebra Barraco", "MC Carol", "Vovó Juju",
                    "Jacinda Ardern", "Ana Hickman", "Regina Casé", "Selena Gomez", "Mulher Pepita", "Tupá Guerra", "Débora dos falsetes", 
                    "Simone", "Lara", "ministra Damares", "Hebe Camargo", "Dilma Roussef", 
                    "Luciana Gimenez", "Kátia Abreu", "Joice Hasselman", "Carla Zambelli", "Ana Maria Braga", 
                    "Xuxa"}, {"Renan dos Santos", "Julinho da Van", "Atila Iamarino", "Louro José", "Toninho do diabo", "Faustão", "Jungkook do BTS", "Inri Cristo", "Rogerinho do Ingá", 
                    "Eymael, o democrata cristão", "Irmão do Jorel", "Luiz Inácio Lula da Silva", "Jair Bolsonaro", "Dr. Auzio Varella", 
                    "Filipe Nobre Figueiredo", "Azaghal", "João Dória", "Tulio Gadelha (namorado da Fatima Bernardes)", "Cid do não Salvo", "Maurílio dos Anjos", "William Bonner (ex da Fatima Bernardes)"} };
            int pontos, salario, escolaridade, estacao, viagem, cor, procura;

            Console.WriteLine("Tinder em tela preta\nResponda as perguntas e encontre seu par ideal\n\nQual a sua renda?\n1 - Até 2 salários mínimos, 2 - De 2 a 4 salários mínimos, 3 - De 4 a 6 salários mínimos, 4 - de 6 a 10 salários mínimos, 5 - mais de 10 salários mínimos");
            salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua escolaridade?\n1 - Não alfabetizado, 2 - Ensino fundamental completo, 3 - Ensino médio completo, 4 - Ensino superior completo, 5 - Mestrado completo, 6 - Doutorado completo");
            escolaridade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua estação do ano preferida?\n1 - Primavera, 2 - Verão, 3 - Outono, 4 - Inverno");
            estacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu destino preferido de viagem?\n1 - Cidade, 2 - Campo, 3 - Praia, 4 - Radical, 5 - Cruzeiro");
            viagem = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a sua cor preferida\n1 - Preto, 2 - Azul, 3 - Verde, 4 - Vermelho, 5 - Branco");
            cor = int.Parse(Console.ReadLine());
            Console.WriteLine("O que procura?\n1 - Mulheres, 2 - Homens");
            procura = int.Parse(Console.ReadLine());
            procura = procura - 1;
            while (procura > 1 || procura < 0)
            {
                Console.WriteLine("Opção de gênero inválida, informe novamente o gênero que procura\n1 - Mulheres, 2 - Homens");
                procura = int.Parse(Console.ReadLine());
                procura = procura - 1;
            }
            pontos = salario + escolaridade + estacao + viagem + cor - 5;
            if (pontos >=0 && pontos < 21)
            {
                Console.WriteLine("Seu par ideal é " + nomes[procura, pontos]);
            }
            else
            {
                Console.WriteLine("Escolheu alguma opção inválida, impossível determinar o seu par ideal");
            }
            Console.ReadKey();
        }
    }
}
