using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int tabuada = int.Parse(Console.ReadLine());
            for (int a=1; a<=10;a++) {
                Console.WriteLine(tabuada + " x " + a + " = " + (tabuada*a));
            }

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
