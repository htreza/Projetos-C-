using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class ListaLigada
    {
        public Node head { get; set; }

        public ListaLigada()
        {
            this.head = new Node(0);
        }

        public void InsereNode(int valor)
        {
            Node novo = new Node(valor);
            novo.Next = head.Next;
            head.Next = novo;
        }

        public void Imprime()
        {
            Node atual = head.Next;
            while (atual != null)
            {
                Console.WriteLine(atual.Info);
                atual = atual.Next;
            }
        }

        public Node BuscaNode(int valor)
        {
            Node atual = head.Next;
            while (atual != null)
            {
                if (atual.Info == valor)
                {
                    return atual;
                }
                else
                {
                    atual = atual.Next;
                }              
            }
            return null;
        }

        public bool RemoveNode(int valor)
        {
            Node ant = head;
            Node atual = head.Next;
            while (atual != null)
            {
                if (atual.Info == valor)
                {
                   ant.Next = atual.Next;
                    return true;
                }
                else
                {
                    ant = atual;
                    atual = atual.Next;
                }
            }
            return false;
        }

        public int Tamanho()
        {
            Node atual = head.Next;
            int tam = 0;
            while (atual != null)
            {
                tam = tam + 1;
                atual = atual.Next;
            }
            return tam;
        }
    }
}
