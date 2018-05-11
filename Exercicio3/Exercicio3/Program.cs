using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[7];
            for (int a = 0; a < 7; a++) {
                Console.WriteLine("Digite o {0}º número", a+1);
                numeros[a] = int.Parse(Console.ReadLine());
            }

            for (int a = 0; a < 7; a++){
                Console.WriteLine("O {0}º número é {1}",a+1,numeros[a]);
            }

            for (int a = 6; a >= 0; a--){
                Console.WriteLine("O {0}º número é {1}", a+1, numeros[a]);
            }

            Console.ReadKey();
        }
    }
}
