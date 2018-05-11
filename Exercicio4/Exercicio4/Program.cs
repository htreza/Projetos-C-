using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Digite o {0}º número", a + 1);
                numeros[a] = int.Parse(Console.ReadLine());
            }

            double calcularMedia = 0;
            for (int a = 0; a < 10; a++)
            {
                calcularMedia += numeros[a];
            }
            calcularMedia = calcularMedia / 10;
            Console.WriteLine("A média é "+calcularMedia);

            string numerosAcimaDaMedia = "Os números acima da média são: ";

            for (int a = 0; a < 10; a++)
            {
                if (numeros[a] > calcularMedia) {
                    numerosAcimaDaMedia += numeros[a]+", ";                    
                }
            }
            Console.WriteLine(numerosAcimaDaMedia);

            Console.ReadKey();
        }
    }
}
