using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            IRodzina Brat = new Rodzina("Kowalski", "Marian", 18);
            IRodzina Mama = new Rodzina("Kowalski", "Stanisława", 54);
            IRodzina Ciotka = new Rodzina("Romanowska", "Krystyna", 76);

            Console.WriteLine("");

            

            List<IRodzina> lista = new List<IRodzina>();

            lista.Add(Brat);
            lista.Add(Mama);
            lista.Add(Ciotka);
            for (int i = 0; i < lista.Count; i++)
            {
                IRodzina Rodzina = lista[i];
                Console.WriteLine("Rok narodzin: ");
                Console.WriteLine(Rodzina.dataUrodzenia());

            }

            Console.ReadLine();
        }
    }
}
