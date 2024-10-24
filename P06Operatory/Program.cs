using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Operatory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1; // opreator przypisania 

            bool czy = a == 1; // == operator porównania 

            a = a + 1;
            a++; // inkrementacja 


            a += 5;// zwieksz o np:  o 5 

            a *= 2; // przemnoz przez 2 to samo co a=a*2 

            a -= 6; // zmniesz o 6 

            a /= 2; // przedziel przez 2 

            bool czyMniesze = a < 5; // czy mniejsze od 

            bool czyWiekszeLubRowne = a >= 5;


            bool b1 = a < 5 || a > 10; // czy a jest mniejsze od 5 lub wieksze od 10 
            bool b2 = a > 5 && a < 10; // operator logiczny i 

            bool b3 = a != 5; // rózne od ... 


            bool b4 = !(a == 5); // ! nieprawda że 




        }
    }
}
