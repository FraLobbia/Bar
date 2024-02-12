using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Ordine
    {
        // property
        public List<SingleComponentMenu> _orderList;
        public double _orderTotal;

        
        public Ordine()
        // costruttore NECESSARIO per istanziare _orderList
        {
            this._orderList = new List<SingleComponentMenu>();
        }


        public void addToOrder(SingleComponentMenu orderItem)
        // Metodo per aggiungere un elemento all'ordine
        // RICEVE un tipo SingleComponentMenu
        // e lo aggiunge alla lista _orderList
        {
            this._orderList.Add(orderItem);
            this._orderTotal += orderItem.Prezzo;
        }

        public void Saluta()
        {
            if (this._orderTotal > 0)
            {
                Console.WriteLine("Il totale del tuo ordine è: " +  this._orderTotal);
                Console.WriteLine("Buona giornata!");
            }
            else
            {
                Console.WriteLine("Se cambi idea siamo a disposizione!");
            }
            
        }
    }
}
