using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAT540031
{
    class Carta
    {

        public string Face { get; set; }
        public int Valor { get; set; }
        public string Naipe { get; set; }

        public Carta(string face, int valor, string naipe)
        {
            Face = face;
            Valor = valor;
            Naipe = naipe;
        }

        public override string ToString()
        {
            return Face + " de " + Naipe;
        }

    }
}
