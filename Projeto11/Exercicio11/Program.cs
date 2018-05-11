using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int par = 0;
            int impar = 0;
            for (int a = 1; a <= 10; a++) {
                Console.WriteLine("Digite o {0}º número",a);
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0) {
                    par++; ;
                }
                else {
                    impar++;
                }

            }
            Console.WriteLine("Números pares: {0} Números ímpares: {1}",par,impar);

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
