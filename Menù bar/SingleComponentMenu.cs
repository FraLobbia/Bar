using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class SingleComponentMenu
    {
      
            public string Nome { get; set; }
            public double Prezzo { get; set; }
            public int Indice { get; set; }

        public SingleComponentMenu(string nome, double prezzo, int index)
        {
            Nome = nome;
            Prezzo = prezzo;
            Indice = index;
        }
    }
}
