using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Powered by Henrique Treza
namespace EDAC140031
{
    class ListaObj
    {
        
        private Object[] vetor;   
        private int nroElem;    

       
        public int NroElem { get => nroElem; set => nroElem = value; }

        
        public ListaObj(int tam)
        {
            vetor = new Object[tam];     
            nroElem = 0;              
        }

        
        public int Adicionar(Object elem)
        {
            if (nroElem >= vetor.Length)   
            {
                return -1;                 
            }

          
            vetor[nroElem++] = elem;

           
            return 0;
        }

        
        public void Exibir()
        {
            if (nroElem == 0)                       
            {
                Console.WriteLine("\nLista vazia");  
            }
            else
            {
                Console.WriteLine("\nLista:");     
                for (int i = 0; i < nroElem; i++)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        
        public int Buscar(Object elem)
        {
            for (int i = 0; i < nroElem; i++)
            {
                if (vetor[i].Equals(elem))       
                {
                    return i;               
                }
            }
           
            return -1;
        }

       
        public int RemoverPeloIndice(int indice)
        {
            if (indice < 0 || indice >= nroElem)    
                                                     
            {
                return -1;                         
            }

            
            for (int i = indice; i < nroElem - 1; i++)
            {
                vetor[i] = vetor[i + 1];
            }
           
            nroElem--;
            return 0;
        }

        
        public int RemoverElemento(Object elem)
        {
            
            return RemoverPeloIndice(Buscar(elem));
        }


        
        public Object GetElemento(int indice)
        {
            if (indice < 0 || indice >= nroElem)   
            {
                return null;                       
            }

            return vetor[indice];           
        }
    }
}
