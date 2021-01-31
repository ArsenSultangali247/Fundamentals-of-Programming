using System;

namespace lab6ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double feet, inch, sum1, sum2;
            Console.WriteLine("Enter distance in ft");
            feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance in inches");
            inch = Convert.ToDouble(Console.ReadLine());
            feet = inch * 12;
            sum1 = feet + inch;
            sum2 = sum1 / 12;
            Console.WriteLine("{0} + {1} = {2} in inches", feet, inch, sum1);
            Console.WriteLine("{0} = {1} in ft", sum1, sum2);
        }
    }
}
