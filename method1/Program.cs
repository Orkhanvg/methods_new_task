using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            double sum = method(a, b);
            Console.WriteLine(sum);
        }

        
        

        static double method (double a, double b)
        {
            return a / b; 
        }


        






    }
}
