using System;

namespace lab7ex1
{
    class Program
    {
        public static void pattern(int n)
        {


            for (int i = 1; i <= n * 2; i++)
                Console.Write(" ");
            Console.WriteLine(0 + "");


            for (int i = 1; i <= (n * 2) - 1; i++)
            {


                if (i < n)
                {
                    for (int j = 1; j <= (n - i) * 2; j++)
                        Console.Write(" ");
                }
                else
                {
                    for (int j = 1; j <= (i % n) * 2; j++)
                        Console.Write(" ");
                }

                if (i < n)
                {
                    for (int j = 0; j <= i % n; j++)
                        Console.Write(j + " ");
                    for (int j = (i % n) - 1; j > 0; j--)
                        Console.Write(j + " ");
                    Console.Write(0);
                }


                else if (i > n)
                {
                    for (int j = 0; j <= n - (i - n); j++)
                        Console.Write(j + " ");

                    for (int j = (n - (i - n)) - 1; j > 0; j--)
                        Console.Write(j + " ");
                    Console.Write(0);
                }
                else
                {
                    for (int j = 0; j <= n; j++)
                        Console.Write(j + " ");
                    for (int j = n - 1; j > 0; j--)
                        Console.Write(j + " ");
                    Console.Write(0);
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= n * 2; i++)
                Console.Write(" ");
            Console.Write(0);
        }
        static void Main(string[] args)
        {
            int n = 4;
            pattern(n);
        }
    }
}
