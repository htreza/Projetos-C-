using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantas unidades deseja comprar:");
            int unidades = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço  de uma unidade:");
            double preco = double.Parse(Console.ReadLine());

            double valorcompra = unidades * preco;
            Console.WriteLine("O valor da sua compra é {0:C}", valorcompra);

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
