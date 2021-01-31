using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double C, K, F;
            Console.WriteLine("Enter degree in C");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter degree in K");
            K = C + 273.15;
            F = C * 1.8 + 32;
            Console.WriteLine("{0}C = {1}K", C, K);
            Console.WriteLine("{0}C = {1}F", C, F);
        }
    }
}
