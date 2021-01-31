using System;

namespace lab2ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, m, t;
            Console.WriteLine("enter the distance in kilometres");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the time");
            t = Convert.ToInt32(Console.ReadLine());
            double kph, mph;
            m = k * 0.6214;
            kph = k / t;
            mph = m / t;
            Console.Write("kph = ");
            Console.WriteLine("{0} / {1} = {2}", k, t, kph);
            Console.Write("mph = ");
            Console.WriteLine("{0} / {1} = {2}", m, t, mph);
        }
    }
}
