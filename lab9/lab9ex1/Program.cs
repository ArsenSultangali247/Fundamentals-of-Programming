using System;

namespace lab9ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int rows;
            Console.WriteLine("input num of rows");
            rows = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < rows; i++)
            {
                for(int j = 1; j <= rows - i; j++)
                {
                    Console.Write(' ');
                }
                for(int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("F");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
