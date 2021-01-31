using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(a % 3 == 0 || a % 7 == 0);
            }
        }
    }
}
