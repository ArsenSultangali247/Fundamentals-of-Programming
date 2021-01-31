using System;

namespace lab6ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int r, m1, m2, m3;
            float t;
            string n;
            Console.WriteLine("Enter ID Number :");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();
            Console.WriteLine("Mark of Math : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of Physics : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mark of History : ");
            m3 = Convert.ToInt32(Console.ReadLine());
            t = m1 + m2 + m3;

            Console.WriteLine("Final Grade : " + (t / 3));
        }
    }
}
