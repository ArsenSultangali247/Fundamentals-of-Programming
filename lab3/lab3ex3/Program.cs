using System;

namespace lab3ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a binary number");
            var a = Console.ReadLine();

            var hex = Convert.ToInt32(a, 2).ToString("X");

            Console.WriteLine($"Hex is {hex}");
        }
    }
}
