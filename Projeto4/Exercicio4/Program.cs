using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota da avaliação continuada:");
            double continuada = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da avaliação semestral:");
            double semestral = double.Parse(Console.ReadLine());

            double notaFinal = continuada * 0.4 + semestral * 0.6;
            Console.WriteLine("Você foi " + (notaFinal >= 5.0 ? "Aprovado ":"Reprovado"));

            // Para manter a janela aberta
            Console.ReadKey();
        }
    }
}
