using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjaNaNapisach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string napis = "ala ma kota";
                          //012345678910                            
            int dlugosc = napis.Length; //11

            /* komentarz
             * wielo
             * wieroszy
             */

            Console.WriteLine(dlugosc);

            // F5 uruchomienie programu 


            string s1 = napis.Substring(4); //ma kota

            string s2 = napis.Substring(4,2); // ma


            string naMale = napis.ToLower();
            string naDuze = napis.ToUpper();

            // konkatenacja (laczenie ciagów tekstowych) 
            string s3 = "ala" + "ma" + "kota";
            // alamakota

            string s4 = napis + " i kota";

            string s5 = "ala".ToUpper();

            string s6 = "ala";
            s6 = s6.ToUpper();

            s6.ToUpper(); // tutal "ALA" cały czas bezdie niezmienione 


            string s7 = napis.Replace("ma", "bedzie miała");
            // ala bezdie miala kota 

            int pozycja = napis.IndexOf("ma");
            // 4

            Console.ReadKey();
        }
    }
}
