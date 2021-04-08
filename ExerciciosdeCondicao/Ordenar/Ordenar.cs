using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar
{
    class Ordenar
    {
        static void Main(string[] args)
        {
            /* Utilize o conceito de propriedade distributiva para ordenar os valores. Não use variável auxiliar desta vez. Utilize ifs independentes. Baseie-se no algoritmo:
            Se (numA > numB) Entao
               numB ← numA –numB
               numA ← numA –numB
               numB ← numA + numB
            FimSe

            Se (numA > numC) Entao
                numC ← numA –numC
                numA ← numA –numC
                numC ← numA + numC
            FimSe
        
            Se (numB > numC) Entao
                numC ← numB –numC
                numB ← numB –numC
                numC ← numB + numC
            FimSe

            Exibir numA, numB, numC*/
            int n1, n2, n3;

            Console.WriteLine("Digite um número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                n2 = n1 - n2;
                n1 = n1 - n2;
                n2 = n1 + n2;
            }
            if (n1 > n3)
            {
                n3 = n1 - n3;
                n1 = n1 - n3;
                n3 = n1 + n3;
            }
            if (n2 > n3)
            {
                n3 = n2 - n3;
                n2 = n2 - n3;
                n3 = n2 + n3;
            }
            Console.WriteLine("Os número digitados em ordem crescente são " + n1 + ", " + n2 + ", " + n3);
            Console.ReadKey();
        }
    }
}
