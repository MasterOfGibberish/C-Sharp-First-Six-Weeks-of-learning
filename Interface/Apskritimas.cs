using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Apskritimas : Figura, IGeometrija

    {
        public readonly int Spindulys;

        public Apskritimas (int spindulys, string apskritimoPavadinimas): base(apskritimoPavadinimas)
        {
            Spindulys = spindulys;
        }
        public double Perimetras()
        {
            double apskritimoPerimetras = 2 * Math.PI * Spindulys;
            return apskritimoPerimetras;
        }

        public double Plotas()
        {
            double apskritimoPlotas = Math.PI * Spindulys * Spindulys;
            return apskritimoPlotas;
        }
    }
}
