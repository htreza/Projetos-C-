using PilhaObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540031
{
    class Baralho
    {
        public PilhaObj baralho { get; set; }

        public Baralho()
        {
            string[] Faces = new string[13]{ "Ás", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez", "Valete", "Dama", "Rei" };
            string[] Naipes = new string[4] {"Copas","Paus","Ouros","Espadas"};
            PilhaObj objeto = new PilhaObj(52);
            this.baralho = objeto;
            int cont = 0;
            while (!baralho.IsFull())
            {  
                baralho.Push(new Carta(Faces[cont % 13], cont % 13 + 1, Naipes[cont / 13]));
                cont++;
            }
        }

        public Carta RemoveCarta(int ind)
        {
            PilhaObj aux = new PilhaObj(ind);            
            for (int i = 0; i < ind; i++)
            {
                aux.Push(baralho.Pop());
            }
            Carta alvo = (Carta)baralho.Pop();                                        
            while (!aux.IsEmpty())
            {
                baralho.Push(aux.Pop());
            }           
            return alvo; 
        }

        public void Embaralhar()
        {
            Random nroAleatorio = new Random();
            for(int a = 0; a < 52; a++)
            {
                int indice = nroAleatorio.Next(52);
                this.baralho.Push(RemoveCarta(indice));
            }
        }

        public Carta VirarCarta()
        {            
            return (Carta) this.baralho.Pop();
        }

        public void Exibir()
        {
            this.baralho.ExibePilhaBaseParaTopo();
        }

    }
}
