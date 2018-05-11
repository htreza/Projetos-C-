using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Powered by Henrique Treza
namespace EDAC140031
{
    class Professor
    {
        public string Nome { get; set; }
        public double HorasAula { get; set; }
        public double ValorHora { get; set; }

        public Professor(string nome, double horasAula, double valorHora)
        {
            Nome = nome;
            HorasAula = horasAula;
            ValorHora = valorHora;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Horas Aula: " + HorasAula + " Valor Hora: " + ValorHora;
        }

        public double CalcGanho()
        {
            return (HorasAula * ValorHora) * 5.25 * 1.5;
        }

    }
}
