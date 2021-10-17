using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //var tekstas = File.ReadAllText("manoTekstas.txt");
            //Console.WriteLine(tekstas);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("Ivyko klaida:" + e.Message);
            //}

            //Console.ReadLine();
            try
            {
                int[] masyvas = new int[5];
                int test = Convert.ToInt32(Console.ReadLine());
                masyvas[5] = test;
            }
            catch (IndexOutOfRangeException bandymas)
            {
                Console.WriteLine("Ivyko klaida:"+ bandymas);
            }
            catch(FormatException bandymas1)
            {
                Console.WriteLine("Ivesties blogas tekstas" + bandymas1);
               
            }
            catch (ArgumentNullException bandymas2)
            {
                Console.WriteLine("Null Klaida" + bandymas2);
               
            }
            catch (PathTooLongException bandymas3)
            {
                Console.WriteLine("Per ilgas sk" + bandymas3);
                
            }
            catch (FileNotFoundException bandymas4)
            {
                Console.WriteLine("Failas Nerastas" + bandymas4);

            }                    
            catch (Exception e)
            {
                Console.WriteLine("Ivyko klaida:" + e);
            }

            Console.ReadLine();
        }
    }
    
}
