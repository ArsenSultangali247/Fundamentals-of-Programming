using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int R;
            Console.WriteLine("Enter the radius of a circle");
            R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Perimeter = ");
            Console.WriteLine("{0} * 3.14 = {1}", R, R * 3.14);
            Console.Write("Area = ");
            Console.WriteLine("{0} * {0} * 3.14 = {1}", R, R * R * 3.14);
        }
    }
}
