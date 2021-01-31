using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the number");
            x = int.Parse(Console.ReadLine());
            for (y = 2; x>1; y++)
            {
                if(x % y == 0)
                {
                    int a = 0;
                    while(x % y == 0)
                    {
                        x /= y;
                        a++;
                    }
                    Console.WriteLine("{0} is a prime factor {1}x", y, a);
                }
            }
        }
    }
}
