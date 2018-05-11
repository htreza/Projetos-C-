using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 1; a <= 200; a++)
            {
                if (a % 4 == 0) {
                    Console.WriteLine(a);
                }
           
            }

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
