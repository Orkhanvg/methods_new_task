using System;

namespace Method4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Sahe deyə Method(lar) yaradılır.
            Çevrənin sahəsi - S = p*r² (p=3)
            Düzbucaqlının sahəsi - S = a*b

            Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2
             */
            int circle = sahe(2);
            int rectangular = sahe(3, 4);
            double triangularcircle = sahe(4, 5, 7, 2);
            Console.WriteLine(circle);
            Console.WriteLine(rectangular);
            Console.WriteLine(triangularcircle);




        }


        static int sahe(int r, int p)
        {
            int p = 3;
            return (r * r * p);



        }

        static int sahe (int a, int b)

        {
        return (a * b);

        }
        static double sahe(double a, double b, double c, double r)

        {
            double p = (a + b + c) / 2;

            return (p * r);
        }
    }
}
