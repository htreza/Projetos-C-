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

            string nome;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            int num;
            Console.WriteLine("Olá, {0}! Qual o ano do seu nascimento?(Ex.:1991)", nome);
            num = int.Parse(Console.ReadLine());
            int idade2020 = 2020 - num;
            Console.WriteLine("Em 2020 você terá {0} anos", idade2020);

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
