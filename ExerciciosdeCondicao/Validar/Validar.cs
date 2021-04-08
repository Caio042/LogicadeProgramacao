using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar
{
    class Validar
    {
        static void Main(string[] args)
        {
            // Programa para definir uma faixa de números a ser recebido para o usuário e confirmar se está dentro da faixa ou não.
            int valor;

            Console.WriteLine("Digite um valor de 0 até 100:");
            valor = int.Parse (Console.ReadLine());

            if (valor >=0 && valor <=100)
            {
                Console.WriteLine(valor + " é válido");
            }
            else 
            {
                Console.WriteLine(valor + " é invalido:");
            }
            Console.ReadKey();
        }
    }
}
