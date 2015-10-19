using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Mama : Rodzina

   
    
    {

        private string oczy;
        public Mama(string n, string i, int w, string o)
        {
            nazwisko = n;
            imie = i;
            wiek = w;
            oczy = o;
        }
        public Mama()
        {
            Console.WriteLine("Jak ma na nazwisko?\n");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Jak ma na imie?");
            imie = Console.ReadLine();
            Console.WriteLine("Ile wiosen liczy?");
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Jak ma kolor oczu?");
            oczy = (Console.ReadLine());

        }

        
       
        int dataUrodzenia()
        {
            return 2015-wiek;
        }
    }
}
