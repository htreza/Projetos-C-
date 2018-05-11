using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[10];
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine("Digite o {0}º número", a + 1);
                numeros[a] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um número qualquer:");
            int numeroAleatorio = int.Parse(Console.ReadLine());

            int contador = 0;
            for (int a = 0; a < 10; a++)
            {
                if (numeros[a] == numeroAleatorio)
                {
                    contador++;
                }
            }

            string resultado = contador > 0 ? "O número " + numeroAleatorio + " ocorre " + contador + " vezes" : "O número " + numeroAleatorio + " ocorre nenhuma vez";
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
