using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOrtuZaidimasKaras
{
    class Zaidimas_Karas
    {

        private List<Kortos> _kortuKalade = new List<Kortos>();
        private int _kortuSk = 52;
        private int _kortuSkPradzioje = 52 / 2;
        private string[] _kortuZenklai = new string[] { "Kryzius", "Vynas", "Bugnas", "Sirdis" };

        public void Zaisti()
        {
            var r = new Random();

            
            foreach (Kortos korta in _kortuKalade)
            {
                Console.WriteLine($"RANDOM: {r.Next(0, 36)}");
               
            }
        }
    }
}
