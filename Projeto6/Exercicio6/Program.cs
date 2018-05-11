using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número maior que 100:");
            int numero = int.Parse(Console.ReadLine());

            for (int a = 100; a <= numero; a++) {
                Console.WriteLine(a);
            }

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
