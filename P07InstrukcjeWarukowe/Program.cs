using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P07InstrukcjeWarukowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swój wzrost");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            // wypisz "wysoki" gdy wzrost wyższy niz 180 wpp. wypisz niski 

            bool c1 = wzrost > 180; // True lub False 

           // int wzrost2 = null;


            if (c1)
            {
                Console.WriteLine("wysoki");
            }
            else
            {
                Console.WriteLine("niski");
            }


            if(c1)
                Console.WriteLine("wysoki");
            else
                if(wzrost> 160)
                    Console.WriteLine("śerdni");
                else
                    Console.WriteLine("niski");

            // gdy sie da to warto unikac zagniezdzen 

            if (wzrost > 180)
                Console.WriteLine($"twój wzrost to {wzrost} i jest wysoki");
            else if (wzrost > 160)
                Console.WriteLine($"twój wzrost to {wzrost} i jest średni");
            else if (wzrost > 150)
                Console.WriteLine($"twój wzrost to {wzrost} i jest niski");
            else
                Console.WriteLine($"twój wzrost to {wzrost} i jest bardzo niski");


            // zapobieganie powarzjacym sie kawałkom kodu 

            string raport;
            if (wzrost > 180)
                raport = "wysoki";
            else if (wzrost > 160)
                raport = "średni";
            else if (wzrost <= 160)
                raport = "niski";
            else
                raport = "bardzo niski";

            Console.WriteLine(raport);

            raport = $"twój wzrost to {wzrost} i jest {raport}";



            // operator trój-argumntowy 
            string wyn;
            if (wzrost > 180)
                wyn = "wysoki";
            else
                wyn = "niski";


            string wyn1 = wzrost > 180 ? "wysoki" : "niski";

            string wynik2 = wzrost > 180 ? "wysoki" : wzrost < 160 ? "niski" : "średni";

 



        }
    }
}
