using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Ordine
    {
        // Campo per memorizzare gli elementi dell'ordine
        private List<SingleComponentMenu> _ordine;

        // Costruttore
        public Ordine()
        {
            // Inizializza la lista dell'ordine nel costruttore
            _ordine = new List<SingleComponentMenu>();
        }

        // Metodo per aggiungere un elemento all'ordine
        public void addToOrder(SingleComponentMenu orderItem)
        {
            _ordine.Add(orderItem);
        }
    }
}
