using System;

namespace lab2ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter 1st number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 >= -10 && Num1 <=10 || Num2 >= -10 && Num2 <= 10)
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
