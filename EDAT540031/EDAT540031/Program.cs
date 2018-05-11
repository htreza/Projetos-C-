using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540031
{
    class Program
    {
        static void Main(string[] args)
        {
            Baralho baralho1 = new Baralho();

            baralho1.Exibir();
            Console.WriteLine(" ");
            baralho1.Embaralhar();
            baralho1.Exibir();
            Console.WriteLine(" ");
            Console.WriteLine(baralho1.RemoveCarta(5));
            Console.WriteLine(" ");
            baralho1.Exibir();

            Console.ReadKey();
        }
    }
}
