using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Powered by Henrique Treza
namespace EDA2Q1_40031
{
    class Medico
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int crm;

        public int Crm
        {
            get { return crm; }
            set { crm = value; }
        }

        private int numConsultas;

        public int NumConsultas
        {
            get { return numConsultas; }
            set { numConsultas = value; }
        }

        private float valorConsulta;

        public float ValorConsulta
        {
            get { return valorConsulta; }
            set { valorConsulta = value; }
        }

        public Medico(string nome, int crm, float valorConsulta)
        {
            this.nome = nome;
            this.crm = crm;
            this.valorConsulta = valorConsulta;
        }

        public void Exibir()
        {
            Console.WriteLine("O médico se chama {0}, o CRM é {1}, o custo da consulta é {2} e atendeu {3} vezes este mês", nome, crm, valorConsulta, numConsultas);

        }

        public float CalculaGanho()
        {
            return numConsultas * valorConsulta;
        }
    }
}
