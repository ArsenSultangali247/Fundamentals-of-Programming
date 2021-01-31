using System;

namespace lab4ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal fac;
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            fac = factorial(num1);
            Console.WriteLine("{0}! = {1}", num1, fac);
        }
        static decimal factorial(int num2)
        {
            if (num2 == 0)
            {
                return 1;
            }
            else
            {
                return num2 * factorial(num2 - 1);
            }
        }
    }
}
