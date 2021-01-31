using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter 1st number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0} + {1})*{2} = {3}", x, y, z, (x+y)*z);
            Console.WriteLine("{0} * {1} = {2}", x, y, x*y);
        }
    }
}
