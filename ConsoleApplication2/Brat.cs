using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Brat : Rodzina
    {
        private string wlosy;
        public Brat(string n, string i, int w, string h)
        {
            nazwisko = n;
            imie = i;
            wiek = w;
            wlosy = h;
        }
        public Brat()
        {
            Console.WriteLine("Jak ma na nazwisko?\n");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Jak ma na imie?");
            imie = Console.ReadLine();
            Console.WriteLine("Ile wiosen liczy?");
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Jak ma kolor wlosow?");
            wlosy = (Console.ReadLine());

        }

        int dataUrodzenia()
        {
            return 2015 - wiek;
        }
    }
}
