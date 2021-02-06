using System;

namespace lab9ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("The Sum of odd Natural Number upto {0} terms : {1}", n, sum);
        }
    }
}
