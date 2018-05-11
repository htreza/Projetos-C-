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
            Console.WriteLine("Digite o seu salário:");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de imposto a pagar:");
            double imposto = double.Parse(Console.ReadLine());

            double salarioLiquido = salario * (1-(imposto / 100));
            Console.WriteLine("Seu salário líquido é {0:C}", salarioLiquido);

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
