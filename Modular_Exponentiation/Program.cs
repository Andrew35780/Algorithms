using System;

namespace Modular_Exponentiation
{
    internal class Program
    {
        static int ModularExponentiation(int x, int d, int n)
        {
            int z;

            if (d == 0)
                return 1;
            else if (d > 0 && d % 2 == 0)
            {
                z = ModularExponentiation(x, d / 2, n);
                return z * z % n;
            }
            else
            {
                z = ModularExponentiation(x, (d - 1) / 2, n);
                return z * z * x % n;
            } 
        }

        static void Main(string[] args)
        {
            int x = 10;
            int d = 6;
            int n = 15;

            Console.WriteLine(ModularExponentiation(x, d, n));
        }
    }
}
