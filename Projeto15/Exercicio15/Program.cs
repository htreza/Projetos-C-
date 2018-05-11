using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente");
            int expoente = int.Parse(Console.ReadLine());
            int resultado = numero;
            for(int a = 1; a < expoente; a++)
            {
                resultado = resultado * numero;
            }

            Console.WriteLine("{0} elevado a {1} resulta em {2}",numero,expoente,resultado);

            Console.ReadKey();

        }
    }
}
