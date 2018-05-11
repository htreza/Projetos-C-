using System;
namespace PilhaObjetos
{
    public class PilhaObj
    {

        int topo;
        object[] pilhaObj;
        
        public PilhaObj(int tam)
        {
            pilhaObj = new object[tam];
            topo = -1;
        }
        
        public bool IsEmpty()
        {
           return topo == -1;
        }

        public bool IsFull()
        {
            return topo == pilhaObj.Length - 1;
        }

        public void Push(object info)
        {

            if (!IsFull())
            {
               pilhaObj[++topo] = info;
            }
            else
            {
                Console.WriteLine("Pilha cheia!");
            }
        }

        public object Pop()
        {
            if (!IsEmpty())
            {
                return pilhaObj[topo--];

            }
            else
            {
                Console.WriteLine("Pilha vazia :( ");
                return null;
            }
        }
        
        public void ExibePilhaBaseParaTopo()
        {
            Console.WriteLine("Exibindo a pilha da base para o topo");
            for (int i = 0; i <= topo; i++)
            {
                Console.WriteLine(pilhaObj[i]);
            }
        }
                
        public void ExibePilhaTopoParaBase()
        {
            Console.WriteLine("Exibindo a pilha do topo para base");
            for (int i = topo; i >= 0; i--)
            {
                Console.WriteLine(pilhaObj[i]);
            }
        }

        public object multiPop(int n)
        {

            if(IsEmpty() || n > topo){

                return null;                
            }
            PilhaObj aux = new PilhaObj(n);
            for (int i = 0; i < n; i++){
                aux.Push(this.Pop());
            }
            return aux;
        }

        public void multiPush(PilhaObj aux)
        {

            while(!aux.IsEmpty()){
                this.Push(aux.Pop());
            }
        }
    }
}
