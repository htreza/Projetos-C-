using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Powered by Henrique Trezza
namespace EDA2Q2_40031
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB;

            do
            {
                Console.WriteLine("Digite o primeiro número: (Entre 3 e 21, por gentileza)");
                numeroA = int.Parse(Console.ReadLine());
            } while (numeroA < 3 || numeroA > 21);

            do
            {
                Console.WriteLine("Digite o segundo número: (Entre 3 e 21, por gentileza)");
                numeroB = int.Parse(Console.ReadLine());
            } while (numeroB < 3 || numeroB > 21);

            DivImpar divA = new DivImpar(numeroA);
            DivImpar divB = new DivImpar(numeroB);

            divA.Mostrar();
            Console.WriteLine("O resultado é {0}", divA.Multiplicador());

            divB.Mostrar();
            Console.WriteLine("O resultado é {0}", divB.Multiplicador());

            Console.ReadKey();
        }
    }
}
