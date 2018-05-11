using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Digite o {0}º nome", a + 1);
                nomes[a] = Console.ReadLine();
            }

            Console.WriteLine("Digite um nome qualquer:");
            string nomeDigitado = Console.ReadLine();

            for (int a = 0; a < 10; a++)
            {
                if (nomeDigitado == nomes[a])
                {
                    Console.WriteLine("Sua posição no vetor é " + a);
                    continue;
                }

            }

            Console.ReadKey();

        }
    }
}
