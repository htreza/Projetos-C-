using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int a = 1; a <= 400; a++)
            {
                if (a % 2 == 0) { 
                Console.WriteLine("{0} + {1} = {2}", soma, a, (soma + a));
                soma += a;
                }
            }

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
