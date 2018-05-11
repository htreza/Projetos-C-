using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Node
    {
        public int Info { get; set; }
        public Node Next { get; set; }

        public Node(int info)
        {
            Info = info;
            Next = null;
        }
    }
}
