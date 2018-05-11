using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Powered by Henrique Treza
namespace EDAC140031
{
    class Program
    {
        static void Main(string[] args)
        {

            Professor prof1 = new Professor("Celia", 25, 30);
            Professor prof2 = new Professor("Rafael", 40, 40);
            Professor prof3 = new Professor("Gatti", 50, 50);

            Faculdade facu = new Faculdade(3);

            facu.AdicionaProf(prof1);
            facu.AdicionaProf(prof2);
            facu.AdicionaProf(prof3);

            Console.WriteLine("Exibe Recursivo");
            facu.ExibeProfRecursivo();

            Console.WriteLine("Calculo Ganho Total Iterativo: " + facu.CalcTotalGanhoIterativo());

            Console.WriteLine("Calculo Ganho Total Recursivo: " + facu.CalcTotalGanhoRecursivo());

            Console.WriteLine("Busca Prof Celia: " + facu.BuscaProf("Celia"));
            Console.WriteLine("Busca Prof Ronaldo: (não existe)" + facu.BuscaProf("Ronaldo"));

            Console.WriteLine("Atualiza horas prof. Celia: " + facu.AtualizaHorasProf("Celia", 50));

            Console.ReadKey();

        }
    }
}
