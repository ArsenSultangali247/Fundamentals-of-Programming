using System;

namespace lab1ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, Num3, Num4;
            Console.WriteLine("Enter 1st number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4th number");
            Num4 = Convert.ToInt32(Console.ReadLine());
            int avg = (Num1 + Num2 + Num3 + Num4)/4;
            Console.WriteLine("({0} + {1} + {2} + {3})/4 = {4}", Num1, Num2, Num3, Num4, avg);
        }
    }
}
