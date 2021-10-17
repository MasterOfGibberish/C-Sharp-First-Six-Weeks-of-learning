using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Else_Switc
{
    class Program
    {
        static void Main(string[] args)
        {
            ModernusMetodas();
            Console.ReadLine();

            //int a, b;
            //Console.WriteLine("Irasyk sk");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = a % 2;
            //if (b == 0)
            //{
            //    Console.WriteLine("sk dalijasi is 2");
            //}
            //else if (b != 0)
            //{
            //    Console.WriteLine("sk nesidalijasi is 2");
            //}

            //Console.ReadLine();

            /////////////////////////////////

            //int a, b, c;
            //Console.WriteLine("Irasyk skirtingus sk");
            //Console.ReadLine();
            //Console.WriteLine("Irasyk pirma sveikaji sk ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Irasyk antra sveikaji sk");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Irasyk trecia sveikaji sk");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    Console.WriteLine("a didziausias sk");
            //}
            //if (b > a && b > c)
            //{
            //    Console.WriteLine("b didziausias sk");
            //}
            //if (c > a && c > b)
            //{

            //    Console.WriteLine("c didziausias sk");
            //}
            //Console.ReadLine();

            ///////////////////////////

            //int a = 99;
            //int b = 2;
            //int c = 3;

            //bool ar1skdid = a > b && a < 100;
            //bool antrasalyga = a < b;
            //if (ar1skdid || antrasalyga)
            //{
            //    Console.WriteLine("pirmas skaičius didesnis už antrą skaičių ir yra mažesnis už 100");
            //}
            //else
            //{
            //    Console.WriteLine("Ivyko klaida");
            //}
            //Console.ReadLine();

            ////////////////////////////////////

            //int a, b, c;
            //int manosk;
            //Console.WriteLine("Irasyk skirtingus sk");
            //Console.ReadLine();
            //Console.WriteLine("Irasyk pirma sveikaji sk ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Irasyk antra sveikaji sk");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Irasyk trecia sveikaji sk");
            //c = Convert.ToInt32(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine(manosk = a + b + c);
            //        break;
            //    case 2:
            //    Console.WriteLine(manosk = a - c);
            //    break;
            //    case 3:
            //        Console.WriteLine(manosk = b * c);
            //        break;
            // default: 
            // Console.WriteLine("Ivyko klaida");
            //}
            //Console.ReadLine();

            ///////////////////////////////

            //int pasirinkimas;
            //Console.WriteLine("Pasirnkite Gerima");
            //Console.WriteLine("1-limonadas\n 2-arbata\n 3-kakava\n 4-nieko\n");
            //pasirinkimas = Convert.ToInt32(Console.ReadLine());
            //switch (pasirinkimas)
            //{
            //    case 1:
            //        Console.WriteLine("Jus pasirinkote limonada");
            //        break;
            //    case 2:
            //        Console.WriteLine("Jus pasirinkote arbata");
            //        break;
            //    case 3:
            //        Console.WriteLine("Jus pasirinkote kakava");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jus pasirinkote nieko");
            //        break;
            //    default:
            //        Console.WriteLine("Blogas pasirinkimas");
            //        break;
            //}
            //Console.ReadLine();

            ////////////////////////////////

            //for (int i=0; i<20; i += 3)
            //{
            //    Console.WriteLine($"ats {i}");
            //}
            //Console.ReadLine();

            ///////////////////////////

            //for (int i = 0; i < 30; i++)
            //{ if (i % 3 == 0)
            //    {
            //        Console.WriteLine($"ats {i}");
            //    }
            //}
            //Console.ReadLine();

            ///////////////////////

            //for (int i = 0; i < 30; i+=3)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine($"ats {i}");
            //    }
            //}
            //Console.ReadLine();

            //////////////////////////////


            //int a, b,c;
            //Console.WriteLine("Pradzios sk");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Pabaigos sk");
            //b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine("Blogas rezimas, ponuli");
            //}
            //else if (b > a) {
            //    for (int i=a; i < b; i++)
            //    {
            //        c = i * i;
            //        Console.WriteLine($"sk {i} rezimas{c}");
            //    }
            //}
            //Console.ReadLine();

            ////////////////////////

            //int suma = 0;
            //for (int i = 1; i < 1000; i++)
            //{
            //        if ((i % 3 == 0 )||( i % 5 == 0))
            //        {
            //        suma += i;
            //        }
            //}
            //Console.WriteLine($"suma {suma}");
            //Console.ReadLine();

            ////////////////////////////////////

            //int a = 1;
            //for ( int i = 1; i < 100; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        a = a * i;
            //    }
            //}
            //Console.WriteLine($"ats{a}");
            //Console.ReadLine();

            ////////////////////////////////////
            ///

            //Console.WriteLine(" Pasirinkite ar:\n" +
            //    "1 - Loptopas; ar 2 - Stacionarus");
            //int a = Convert.ToInt32(Console.ReadLine());

            //while (a != 1 && a != 2)
            //{
            //    Console.WriteLine("Pasirinkite is naujo");
            //    a = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Pasirinkote{a}");
            //Console.ReadLine();

            ////////////////////////////////////


        }
        public static void ModernusMetodas()
        {
            List<Automobilis> AutomobiliuSarasas = new List<Automobilis>();
           for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Iveskite automobilio metus");
                int metai = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite automobilio marke");
                string marke = Console.ReadLine();
                Console.WriteLine("Iveskite automobilio rida");
                int rida = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite ar automobilio turi technikine (taip arba ne)");
                bool ta = Console.ReadLine().ToLower() =="taip";
                Automobilis auto = new Automobilis(metai, marke, rida, ta);
                AutomobiliuSarasas.Add(auto);

            }
            foreach (var auto in AutomobiliuSarasas)
            {
                Console.WriteLine($"Automobilio metai:{auto.Metai} Automobilio marke: {auto.Marke} Automobilio rida: {auto.Rida}Automobilio technikine: {auto.Ta}");
            }
        }
    }
}
