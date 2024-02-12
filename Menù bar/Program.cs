using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Menu myMenu = new Menu();

        
         
                // Creazione della lista di SingleComponentMenu chiamata menu
               // _menu = new List<SingleComponentMenu>();

                // Aggiungo degli ingredienti alla lista
                myMenu.addToMenu("Coca Cola 150ml", 2.50, 1);
                myMenu.addToMenu("Insalata Di Pollo", 5.20, 2);
                myMenu.addToMenu("Pizza Margherita", 10.00, 3);
                myMenu.addToMenu("Pizza 4 Formaggi", 12.50, 4);
                myMenu.addToMenu("Patatine Fritte", 3.50, 5);
                myMenu.addToMenu("Insalata Di Riso", 8.00, 6);
                myMenu.addToMenu("Frutta Di Stagione", 5.00, 7);
                myMenu.addToMenu("Pizza Fritta", 5.00, 8);
                myMenu.addToMenu("Piadina Vegetariana", 6.00, 9);
                myMenu.addToMenu("Panino Hamburger", 7.90, 10);
           


   
            myMenu.MostraMenu();
            myMenu.CreaOrdine();


            Console.ReadLine();
        }
    }
}
