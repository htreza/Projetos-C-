using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int soma = 0;
            while (a != 0)
            {
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero != 0) {
                    soma += numero;
                }
                else {
                    a = 0;
                }

            Console.WriteLine("Soma: "+soma);
            }

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
