using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Bar
{

    internal class Menu
    {
        // property
        public List<SingleComponentMenu> _menu;
        public double _orderTotal;
        public Menu()
            // questo costruttore è NECESSARIO per istanziare _menu ogni volta
        {
            _menu = new List<SingleComponentMenu>();
        }

        public void addToMenu(SingleComponentMenu orderItem)
        // Metodo per aggiungere un elemento al menu
        // RICEVE direttamente un tipo SingleComponentMenu
        // e lo aggiunge alla lista _menu
        {
            this._menu.Add(orderItem);
        }
        public void addToMenu(string nome, double prezzo, int id)
        // OVERLOADING del metodo per aggiungere un elemento al menu
        // RICEVE i dati necessari per creare un SingleComponentMenu
        // e lo aggiunge alla lista _menu
        {
            
            this._menu.Add(new SingleComponentMenu(nome, prezzo, id));
        }

        public void MostraMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================================");
            Console.WriteLine("                   MENU                     ");
            Console.WriteLine("============================================");
            Console.ResetColor();
            // Ciclo For per stampare tutti gli item nella lista _menu
            foreach (var item in _menu)
            {
                Console.WriteLine($"{item._id}) {item.Nome}: \u20AC {item.Prezzo}");
            }
            Console.WriteLine("\n");
        }

        public void CreaOrdine()
        {
            string inputUtente;
            int scelta;
            Console.WriteLine("Ordina premendo il tasto corrispondente, quando sei pronto premi y:");

            // istanzio un nuovo ordine
            Ordine newOrdine1 = new Ordine();
            do
            {
                inputUtente = Console.ReadLine();

                // Prova a convertire la stringa ricevuta come input in un intero per poter essere usata come indice
                if (int.TryParse(inputUtente, out scelta))
                {
                    // il metodo addToOrder accetta un dato di tipo SingleComponentMenu.
                    // qui lo passa indicizzandolo dalla lista _menu
                    // e lo aggiunge all'ordine istanziato
                    newOrdine1.addToOrder(_menu[scelta -1]);


                    Console.WriteLine("L'ordine contiene: ");
                    // qui mi stampa ogni item della lista _orderList
                    foreach (var item in newOrdine1._orderList)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"{item._id}) {item.Nome}: \u20AC {item.Prezzo}"); 
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Totale Ordine: "+ newOrdine1._orderTotal);
                    Console.ResetColor();

                    Console.WriteLine("\n");
                    Console.WriteLine("Continua ad ordinare altrimenti premi y per confermare");
                }

            } while (inputUtente != "y");

            newOrdine1.Saluta();

            Console.WriteLine("\n");
            MostraMenu();

        }
    } 
}
