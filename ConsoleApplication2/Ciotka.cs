using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Ciotka : Rodzina
    {
        private int wzrost_w_cm;
        public Ciotka(string n, string i, int w, int c)
        {
            nazwisko = n;
            imie = i;
            wiek = w;
            wzrost_w_cm = c;
        }
        public Ciotka()
        {
            Console.WriteLine("Jak ma na nazwisko?\n");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Jak ma na imie?");
            imie = Console.ReadLine();
            Console.WriteLine("Ile wiosen liczy?");
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Jaki ma wzrost w centymetrach?");
            wzrost_w_cm = int.Parse(Console.ReadLine());

        }

        int dataUrodzenia()
        {
            return 2015 - wiek;
        }
    }
}
