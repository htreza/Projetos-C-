using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto:");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código de desconto: ");
            int desconto = int.Parse(Console.ReadLine());

            double valorComDesconto = produto;
            switch (desconto){
                case 1:
                    valorComDesconto = valorComDesconto * 0.95;
                    break;
                case 2:
                    valorComDesconto = valorComDesconto * 0.9;
                    break;
                case 3:
                    valorComDesconto = valorComDesconto * 0.8;
                    break;
                case 4:
                    valorComDesconto = valorComDesconto * 0.5;
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }

            Console.WriteLine("O valor do produto é {0} e o valor com desconto é {1}",produto,valorComDesconto);

            Console.ReadKey();

        }
    }
}
