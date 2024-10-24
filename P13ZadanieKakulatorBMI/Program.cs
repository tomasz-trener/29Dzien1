using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ZadanieKakulatorBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoja wage w kilogramach");
            int waga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost w centymetrach");
            int wzrost = Convert.ToInt32(Console.ReadLine());

            int a = 10 / 3; // wynik: 3 
            double b = 10 / 3.0;

            //  double bmi = waga / (wzrost / 100.0 * wzrost / 100.0);

            double bmi = waga / Math.Pow(wzrost / Convert.ToDouble(100), 2);

            // mozna zaokraglic Math.Round 

            //Console.WriteLine($"Twoje BMI to {bmi:F2}");
            Console.WriteLine($"Twoje BMI to {bmi:000.0}");

            if(bmi < 18.5)
                Console.WriteLine("Masz niedowage");
            else if( bmi < 25)
                Console.WriteLine("Twoja waga jest normie");
            else if (bmi < 30)
                Console.WriteLine("Nadwaga");
            else if (bmi < 35)
                Console.WriteLine("Otyłość I stopnia");
            else if (bmi < 40)
                Console.WriteLine("Otyłość II stopnia (kliniczna)");
            else 
                Console.WriteLine("Otyłość III stopnia (ekstremalna)");
            
            Console.ReadKey();



        }
    }
}
