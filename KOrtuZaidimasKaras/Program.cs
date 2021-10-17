using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOrtuZaidimasKaras
{
    class Program
    {
        static void Main(string[] args)
        {
            int _kortuSkPradzioje = 52 / 2;
            int _kortuSk = 52;
            string[] kortuZenklai = new string[] { "Kryzius", "Vynas", "Bugnas", "Sirdis" };
            List<Kortos> kortuKalade = new List<Kortos>();

            //Zaidimas_Karas zaidimas = new Zaidimas_Karas(2);
            //zaidimas.Zaisti();

            foreach (Kortos korta in kortuKalade)
            {
                Console.WriteLine($"{korta.Zenklas} {korta.Verte} {korta.Indeksas}");

            }

            Console.WriteLine(kortuKalade.Count);

            Console.Read();
        }
    }

        



         
    
}

    

