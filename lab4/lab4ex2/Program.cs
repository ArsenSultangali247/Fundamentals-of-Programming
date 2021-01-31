using System;

namespace lab4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Write first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("After swap : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
