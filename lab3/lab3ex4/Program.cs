using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum, n;
            string divs = " ";
            Console.WriteLine("Enter the number");
            n = int.Parse(Console.ReadLine());
            sum = 0;
            for(int i = 1; i < n; i++)
            {
                if (n % 1 == 0 && n % i == 0)
                {
                    sum = sum + i;
                    divs = divs + i.ToString() + "+";
                }
            }
            divs = divs.Remove(divs.Length - 1, 1);
            Console.WriteLine(divs + " = " + sum);
            if (sum == n)
            {
                Console.WriteLine("Number is perfect");
            }
            else
            {
                Console.WriteLine("Number is not perfect");
            }
            Console.ReadKey();
        }
    }
}
