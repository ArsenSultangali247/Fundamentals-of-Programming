using System;

namespace lab9ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a = new int[10];
            Console.WriteLine("Enter the number to convert: ");
            int n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.WriteLine("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}
