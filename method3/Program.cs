using System;

namespace method3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Return = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int massive = Massive(Return);
            Console.WriteLine(massive);
        }


        /*Bir method olsun göndərilən 
         * "n" sayda ədədin hamsını toplayıb 
         * geri qaytarsın.
         */

        static int Massive(int[] Return)
        {
            int sum = 0;
            foreach (var item in Return)
            {
                
                sum += item;

            }
            return sum; 
        }




    }
}
