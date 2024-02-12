using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Bar
{
    internal static class Menu
    {
        // Proprietà statica per il menu
        private static List<SingleComponentMenu> _menu;

        // Proprietà pubblica statica per accedere al menu
        public static List<SingleComponentMenu> MenuList
        {
            get { return _menu; }
        }

        static Menu()
        {
            InizializzaMenu();
        }

        private static void InizializzaMenu()
        {
            // Creazione della lista di SingleComponentMenu chiamata menu
            _menu = new List<SingleComponentMenu>();

            // Aggiungo degli ingredienti alla lista
            _menu.Add(new SingleComponentMenu("Coca Cola 150ml", 2.50, 1));
            _menu.Add(new SingleComponentMenu("Insalata Di Pollo", 5.20, 2));
            _menu.Add(new SingleComponentMenu("Pizza Margherita", 10.00, 3));
            _menu.Add(new SingleComponentMenu("Pizza 4 Formaggi", 12.50, 4));
            _menu.Add(new SingleComponentMenu("Patatine Fritte", 3.50, 5));
            _menu.Add(new SingleComponentMenu("Insalata Di Riso", 8.00, 6));
            _menu.Add(new SingleComponentMenu("Frutta Di Stagione", 5.00, 7));
            _menu.Add(new SingleComponentMenu("Pizza Fritta", 5.00, 8));
            _menu.Add(new SingleComponentMenu("Piadina Vegetariana", 6.00, 9));
            _menu.Add(new SingleComponentMenu("Panino Hamburger", 7.90, 10));
        }

        public static void MostraMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("                   MENU                     ");
            Console.WriteLine("============================================");

            // Ciclo For per stampare tutti gli ingredienti e relativo prezzo
            foreach (var item in _menu)
            {
                Console.WriteLine($"{item.Indice}) {item.Nome}: \u20AC {item.Prezzo}");
            }
            Console.WriteLine("\n");
        }

        public static void RichiediScelta()
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

                    // il metodo addToOrder accetta un dato di tipo SingleComponentMenu
                    // e lo aggiunge all'ordine istanziato
                    newOrdine1.addToOrder(_menu[scelta]);

                    Console.WriteLine("Hai scelto: " + _menu[scelta].Nome);
                    Console.WriteLine("\n");
                    Console.WriteLine("Continua ad ordinare altrimenti premi y per confermare");
                }

            } while (inputUtente != "y");
        }
    }
}
