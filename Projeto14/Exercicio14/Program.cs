using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int mussarela = 0;
            int calabresa = 0;
            int quatroqueijos = 0;

            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine("Votação do sabor de pizza favorito: \n" +
                    "Para votar no sabor de pizza mussarela, digite 5 \n" +
                    "Para votar no sabor calabresa, digite 25 \n" +
                    "Para votar no sabor quatro queijos, digite 50 \n" +
                    "Votador nº " + a);
                int voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 5:
                        mussarela++;
                        break;
                    case 25:
                        calabresa++;
                        break;
                    case 50:
                        quatroqueijos++;
                        break;
                }
            }

            Console.WriteLine("O sabor mussarela recebeu " + mussarela + " votos");
            Console.WriteLine("O sabor calabresa recebeu " + calabresa + " votos");
            Console.WriteLine("O sabor quatro queijos recebeu " + quatroqueijos + " votos");
            string saborfavorito = mussarela > calabresa && mussarela > quatroqueijos ? "mussarela" : calabresa > quatroqueijos ? "calabresa": "quatro queijos";
            Console.WriteLine("O sabor favorito é "+saborfavorito);

            Console.ReadKey();
        }
    }
}
