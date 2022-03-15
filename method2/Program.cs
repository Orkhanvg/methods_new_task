using System;

namespace method2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = (Console.ReadLine());

            int count = Convert.ToInt32(Console.ReadLine());

            return1(word, count);
            Console.WriteLine(return1(word, count));
        }






        static string return1 (string word, int count)
        {
            string sum = word;
            for (int i = 1; i<count; i++)
            {

                sum += word;
                    
}
            return sum;


            {


            }




           }
    }
}
