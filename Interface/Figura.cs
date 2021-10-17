using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Figura:Geometrija
    {
        private readonly string _figurosPavadinimas;

        public Figura(string pavadinimas)
        {
            _figurosPavadinimas = pavadinimas;
        }

        public double KvadratoPlotas (double skaicius)
        {
            double plotas = skaicius * skaicius;
            return plotas;
        }
        public double StaciakampioPlotas(double skaicius)
        {
            double plotas = skaicius * skaicius;
            return plotas;
        }
    }
