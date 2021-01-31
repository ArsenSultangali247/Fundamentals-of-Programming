using System;

namespace lab2ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double R;
            Console.WriteLine("enter the radius of the sphere");
            R = Convert.ToInt32(Console.ReadLine());
            double Sur, Vol;
            Sur = 4 * 3.14 * R * R;
            Console.Write("Surface = ");
            Console.WriteLine("4 * 3.14 * {0} * {0} = {1}", R, Sur);
            Vol = 4 * 3.14 * R * R * R / 3;
            Console.Write("Volume = ");
            Console.WriteLine("4 * 3.14 * {0} * {0} * {0} / 3 = {1}", R, Vol);
        }
    }
}
