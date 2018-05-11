using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaLigada lista = new ListaLigada();

            lista.InsereNode(1);
            lista.InsereNode(2);
            lista.InsereNode(3);
            lista.InsereNode(4);

            lista.Imprime();
            
            Console.WriteLine(lista.BuscaNode(3).Info);

            Console.WriteLine(lista.RemoveNode(2)? "Removeu": "Não Removeu");

            Console.WriteLine(lista.Tamanho());

            lista.Imprime();

            Console.ReadKey();



        }
    }
}
