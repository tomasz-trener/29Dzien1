using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace P11InnePetle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 while 

            while (true) 
            {
                if (true)
                {
                    break;
                }
            }

            // do while 

            string zdanie = "ala ma kota";

            // wypisz wszystkie znaki w zdaniu  

            // zakaldamy, ze zdanie ma przynajmniej 1 znak 
            int i = 0;
            do
            {
                Console.WriteLine(zdanie.Substring(i, 1));
                i++;
            } while (i < zdanie.Length);



            // for
            for (int j = 0; j < zdanie.Length; j++)
            {
                Console.WriteLine(zdanie.Substring(j, 1));
            }

            //mozemy modyfikowac parametry petli for 
            for (int j = zdanie.Length - 1; j >= 0; j--)
                Console.WriteLine(zdanie.Substring(j, 1));


            for (int j = zdanie.Length - 1; j > -1; j-=2)
                Console.WriteLine(zdanie.Substring(j, 1));


            // czesto bedzie tak, ze bezdiemy iterowac po wszystkich elementach zbioru 

            foreach (char literka in zdanie)
            {
                Console.WriteLine(literka);
            }

            var x = 5; // int 
            //x = "g";

            dynamic x2 = 5;
            x2 = "ala";

            foreach (var literka in zdanie)
            {
                if (literka== 'n')
                {
                    continue; // przejdz do nastepnej iteracji 
                }
                Console.WriteLine(literka);
            }

            
            // podsumowanie: 
            // while, do.. while, for, foreach 
            // break, continue 

        }
    }
}
