using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int soma = 0;
            int contador = 0;
            while (a >= 0) {
                Console.WriteLine("Digite um número:");
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    soma += numero;
                    contador++;
                }
                else {
                    a = numero;
                }
            }

            Console.WriteLine("A soma resulta em {0}, a média é {1}, e o total de números lidos é {2}",soma,(soma/contador),contador);

            Console.ReadKey();
        }
    }
}
