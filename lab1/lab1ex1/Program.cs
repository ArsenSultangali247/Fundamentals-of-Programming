﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter 1st number");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", Num1, Num2, Num1 + Num2);
            Console.WriteLine("{0} - {1} = {2}", Num1, Num2, Num1 - Num2);
            Console.WriteLine("{0} * {1} = {2}", Num1, Num2, Num1 * Num2);
            Console.WriteLine("{0} / {1} = {2}", Num1, Num2, Num1 / Num2);
        }
    }
}
