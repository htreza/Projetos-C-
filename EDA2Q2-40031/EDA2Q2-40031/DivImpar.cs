using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Powered by Henrique Treza
namespace EDA2Q2_40031
{
    class DivImpar
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public DivImpar(int numero)
        {
            this.numero = numero;
        }
        public void Mostrar()
        {
            for (int a = 0; a <= numero; a++)
            {
                if (a % 2 == 1 && numero % a == 0)
                {
                    Console.WriteLine("O número é divisível por {0}", a);
                }
            }
        }

        public int Multiplicador()
        {
            int resultados = 0;
            for (int a = 0; a <= numero; a++)
            {
                if (a % 2 == 1 && numero % a == 0)
                {
                    if (resultados == 0)
                    {
                        resultados = a;
                    }
                    else
                    {
                        resultados = resultados * a;
                    }
                }
            }

            return resultados;
        }



    }
}
