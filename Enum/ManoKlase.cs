using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public static class ManoKlase
    {
        public static void ManoMetodos (ManoEnum e)
        {
            for (int i = 1; i <10; i++, e++)
            {
                Console.WriteLine(e);
            }
            for (e = (ManoEmum)1; e <=(ManoEmum)7; e++)
                switch (e)
                {
                    case ManoEmum.Pirmadienis:
                        Console.WriteLine("Dirbame..");
                        break;
                }
        }

    }
}
