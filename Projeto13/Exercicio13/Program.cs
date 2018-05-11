using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());
            string divisores = "Seus Divisores são: ";
            for(int a =1; a < numero; a++)
            {
                if (numero % a == 0) {
                    divisores = divisores + a + ",";
                }
                
            }
            Console.WriteLine(divisores);

            // Para manter a janela aberta
            Console.ReadKey();

        }
    }
}
