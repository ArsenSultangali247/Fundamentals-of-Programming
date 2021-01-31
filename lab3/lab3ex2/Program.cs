using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char operand;
            double c;
            Console.WriteLine("Please enter the first number");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter an operand");
            operand = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            b = Convert.ToDouble(Console.ReadLine());
            switch (operand)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
                default:
                    c = 0;
                    break;
            }
            Console.WriteLine(a.ToString() + ' ' + operand + ' ' + b.ToString() + " = " + c.ToString());
        }
    }
}
