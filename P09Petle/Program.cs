using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;

            while (k < 10)
            {
                k++;
                Console.WriteLine(k);
            }

            string rownanie = "10 200 400";
            //               //0123456

            int pozycjaSpacji = -1;
            int i = 0;
            while (i < rownanie.Length)
            {
                if (rownanie.Substring(i, 1) == " ")
                    pozycjaSpacji = i;
                i++;
            }
            // akurat funkcja do znajdywania ostaniej spacji istnieje 
            //rownanie.LastIndexOf();

            // a co by ylo gdybysmy chcieli zrobic "first occurance" 
            pozycjaSpacji = -1;
            i = 0;
            while (i < rownanie.Length)
            {
                if (rownanie[i] == ' ')
                {
                    pozycjaSpacji = i;
                    break; // przerwij petle
                }
                    

                i++;
            }
 
        }
    }
}
