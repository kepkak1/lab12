using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Rodzina : IRodzina
    {
        public string nazwisko;
        public string imie;
        protected int wiek;

        public Rodzina(string n = "Jastrzębska", string i = "Danuta", int w = 69)
        {
            nazwisko = n;
            imie = i;
            wiek = w;
        }
        
       
        public void wpiszInfo()
        {
            Console.WriteLine("Jak ma na nazwisko?\n");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Jak ma na imie?");
            imie = Console.ReadLine();
            Console.WriteLine("Ile wiosen liczy?");
            wiek = int.Parse(Console.ReadLine());
        }
        public void pokazInfo()
        {
            Console.WriteLine(nazwisko);
            Console.WriteLine(imie);
            Console.WriteLine(wiek);
        }
        
        public int dataUrodzenia()
        {
            return 2015-wiek;
        }
    }

}
