using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Powered by Henrique Treza
namespace EDAC140031
{
    class Faculdade
    {
        public ListaObj Professor { get; set; }

        public Faculdade(int tam)
        {
            Professor = new ListaObj(tam);
        }

        public int AdicionaProf(Professor prof)
        {
            return Professor.Adicionar(prof);
        }

        public string ExibeProfRecursivo(int i = 0)
        {
            if (i >= Professor.NroElem)
            {
                return "Fim da Lista";
            }
            else
            {
                Console.WriteLine(Professor.GetElemento(i));
                return ExibeProfRecursivo(i + 1);
            }
        }

        public double CalcTotalGanhoIterativo()
        {
            double total = 0;
            for (int a = 0; a < Professor.NroElem; a++)
            {
                Professor prof = (Professor)Professor.GetElemento(a);
                total = total + prof.CalcGanho();
            }
            return total;
        }

        public double CalcTotalGanhoRecursivo(int i = 0)
        {
            if (i >= Professor.NroElem)
            {
                return 0;
            }
            else
            {
                Professor prof = (Professor)Professor.GetElemento(i);
                return prof.CalcGanho() + CalcTotalGanhoRecursivo(i + 1);
            }
        }

        public Professor BuscaProf(string nome)
        {
            for (int a = 0; a < Professor.NroElem; a++)
            {
                Professor prof = (Professor)Professor.GetElemento(a);
                if (prof.Nome == nome)
                {
                    return prof;
                }
            }
            return null;
        }

        public string AtualizaHorasProf(string nome, int horas)
        {
            for (int a = 0; a < Professor.NroElem; a++)
            {
                Professor prof = (Professor)Professor.GetElemento(a);
                if (prof.Nome == nome)
                {
                    prof.HorasAula = horas;
                    Professor.RemoverPeloIndice(a);
                    Professor.Adicionar(prof);
                    return "Alterado com sucesso!";
                }
            }
            return "Não encontrado!";
        }

    }
}
