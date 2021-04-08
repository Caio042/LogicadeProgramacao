using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Media
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que leia 4 notas escolares de um aluno e calcule a média aritmética das notas.
            Caso a média seja maior ou igual a 5, exibir a mensagem "Aluno aprovado".
            Se o aluno ficou entre 3 e 5, exibir a mensagem “Recuperação”,
            se não atingiu a média mínima (menos do que 3), exibir a mensagem "Aluno reprovado".
            Apresente junto à mensagem a média do aluno. */
            int nota1, nota2, nota3, nota4, notaFinal;

            Console.WriteLine("Digite a nota do primeiro bimestre");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do segundo bimestre");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceiro bimestre");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do quarto bimestre");
            nota4 = int.Parse(Console.ReadLine());
            notaFinal = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("Sua media de notas é " + notaFinal);

            if (notaFinal >= 5)
            {
                Console.WriteLine("Aluno aprovado!!");
            }
            else if (notaFinal >=3)
                {
                    Console.WriteLine("Recuperação");
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado");
                }
            
            Console.ReadKey();
        }
    }
}
