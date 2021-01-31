using System;

namespace lab6ex3
{
    class Program
    {
        static void printSum(int[] m,
                    int[] s, int n)
        {
            int total = 0;


            for (int i = 0; i < n; i++)
            {
                total += s[i];
                total += (m[i] * 60);
            }


            Console.Write(total / 3600 + " : ");
            total %= 3600;


            Console.Write(total / 60 + ": ");
            total %= 60;


            Console.Write(total);
        }
        static void Main(string[] args)
        {
            int[] m = { 0, 2, 3, 2, 1 };
            int[] s = { 45, 31, 11, 27, 28 };
            int n = m.Length;

            printSum(m, s, n);
        }
    }
}
