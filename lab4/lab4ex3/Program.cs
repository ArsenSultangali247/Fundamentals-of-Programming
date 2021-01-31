using System;

namespace lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, b = 0, flag = 0;
            Console.Write("Write number: ");
            a = int.Parse(Console.ReadLine());
            b = a / 2;
            for (i = 2; i <= b; i++)
            {
                if (a % i == 0)
                {
                    Console.Write("This number not prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("This number is Prime.");
        }
    }
}
