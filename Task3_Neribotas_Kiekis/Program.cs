using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Neribotas_Kiekis
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> SkaiciuSarasas = new List<int>();
            Console.WriteLine("Iveskite skaicius");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius == 0)
            {
                SkaiciuSarasas.Remove(0);
            }
            else
            {
                SkaiciuSarasas.Add(skaicius);
            }
            while (skaicius != 0)
            {
                if (skaicius == 0)
                {
                    SkaiciuSarasas.Remove(0);
                }
                else 
                {
                    Console.WriteLine("Iveskite skaicius");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                    SkaiciuSarasas.Add(skaicius);
                    SkaiciuSarasas.Remove(0);
                }
            }
            SkaiciuSarasas.Sort();
            foreach (var Skaiciai in SkaiciuSarasas)
            {
                Console.Write(Skaiciai);
            }
            Console.WriteLine("Metas Pailseti");
            Console.ReadKey();
        }
    }
}
