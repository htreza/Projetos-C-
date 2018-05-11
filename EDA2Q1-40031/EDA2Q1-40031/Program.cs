using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Powered by Henrique Treza
namespace EDA2Q1_40031
{
    class Program
    {
        static void Main(string[] args)
        {
            Medico medicoA = new Medico("Doctor Ray", 0, 500);
            Medico medicoB = new Medico("Doctor Strange", 1, 1000);

            medicoA.NumConsultas = 7;
            medicoA.Exibir();
            Console.WriteLine("O médico {0} recebeu neste mês R${1:F2}", medicoA.Nome, medicoA.CalculaGanho());

            medicoB.NumConsultas = 10;
            medicoB.Exibir();
            Console.WriteLine("O médico {0} recebeu neste mês R${1:F2}", medicoB.Nome, medicoB.CalculaGanho());

            Console.ReadKey();
        }
    }
}
