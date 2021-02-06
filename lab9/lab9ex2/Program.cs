using System;

namespace lab9ex2
{
    class Program
    {
        static float sumOfAP(float a, float d, float z)
        {
            float sum = (z / 2) *
                        (2 * a +
                        (z - 1) * d);
            return sum;
        }
        static void Main(string[] args)
        {
            float z = 19;
            float a = 2.8f, d = 3.6f;
            Console.WriteLine(sumOfAP(a, d, z));
        }
    }
}
