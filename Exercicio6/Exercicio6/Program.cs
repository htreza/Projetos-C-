using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meses = new int[12];
            meses[0] = 31;
            meses[1] = 28;
            meses[2] = 31;
            meses[3] = 30;
            meses[4] = 31;
            meses[5] = 30;
            meses[6] = 31;
            meses[7] = 31;
            meses[8] = 30;
            meses[9] = 31;
            meses[10] = 30;
            meses[11] = 31;

            Console.WriteLine("Digite o dia:");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês:");
            int mes = int.Parse(Console.ReadLine());

            int diaDoAno = 0;

            for(int a = 0; a < 12; a++){

                if ((mes-1) > a) {
                    diaDoAno += meses[a];
                }

                if ((mes-1) == a){
                    diaDoAno += dia;
                }
            }

            Console.WriteLine("O dia {0}/{1} corresponde ao dia {2} do ano.",dia,mes,diaDoAno);

            Console.ReadKey();
        }
    }
}
