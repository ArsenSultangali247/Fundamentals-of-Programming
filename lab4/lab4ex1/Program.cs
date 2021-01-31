using System;

namespace lab4ex1
{
    class Program
    {
        public static int Count(string str)
        {
            int counter = 0;
            string a;
            for (int i = 0; i < str.Length; i++)
            {
                a = str.Substring(i, 1);
                if (a == " ")
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            string b;
            Console.WriteLine("Input a string");
            b = Console.ReadLine();
            Console.WriteLine(b + "{0} spaces in the string", Count(b));
        }
    }
}
