using System;

namespace lab8ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, n, d, anum;
            int sum = 0;
            Console.WriteLine("Input the first num of the AP");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the num of items in AP");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the difference of AP");
            d = Convert.ToInt32(Console.ReadLine());
            sum = (2 * a1 + d * (n - 1) * n) / 2;
            anum = a1 + (n - 1) * d;
            Console.Write("Sum of Ap = ");
            for(int i = a1; i<= anum; i = i + d)
            {
                if (i != anum)
                {
                    Console.Write("{0} + ", i);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", i, sum);
                }
            }
        }
    }
}
