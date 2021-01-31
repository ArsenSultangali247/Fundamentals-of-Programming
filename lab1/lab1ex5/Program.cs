using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hex;
            Console.WriteLine("Enter hexadecimal number");
            Hex = Convert.ToString(Console.ReadLine());
            int dec = int.Parse(Hex, System.Globalization.NumberStyles.HexNumber);
            Console.Write("Convert to ");
            Console.WriteLine("Decimal number ="+dec);
        }
    }
}
