using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            if(a < 100 && b > 200 || a > 200 && b < 100)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
