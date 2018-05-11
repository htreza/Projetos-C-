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
            Console.WriteLine("Digite o primeiro número inteiro:");
            int primeiro = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número inteiro:");
            int segundo = int.Parse(Console.ReadLine());

            int diferenca = (primeiro > segundo) ? (primeiro - segundo) : (segundo - primeiro);           

            Console.WriteLine("A diferença entre os números é {0}", diferenca);

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
