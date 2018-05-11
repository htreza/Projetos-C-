using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu login:");
            string login = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

            string mensagemErro = "Usuário ou senha inválidos";
            string bemVindo = "Olá, " + login + "! Bem vindo ao sistema!";

            switch (login)
            {
                case "aluno":
                    if (senha == "bandtec")
                    {
                        Console.WriteLine(bemVindo);
                    }
                    else
                    {
                        Console.WriteLine(mensagemErro);
                    }
                    break;
                case "prof":
                    if (senha == "band")
                    {
                        Console.WriteLine(bemVindo);
                    }
                    else
                    {
                        Console.WriteLine(mensagemErro);
                    }
                    break;
                case "coord":
                    if (senha == "colband")
                    {
                        Console.WriteLine(bemVindo);
                    }
                    else
                    {
                        Console.WriteLine(mensagemErro);
                    }
                    break;
                case "admin":
                    if (senha == "bbbbb")
                    {
                        Console.WriteLine(bemVindo);
                    }
                    else
                    {
                        Console.WriteLine(mensagemErro);
                    }
                    break;
                default:
                    Console.WriteLine(mensagemErro);
                    break;
            }

            Console.ReadKey();
        }
    }
}
