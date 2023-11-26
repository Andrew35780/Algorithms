using System;

namespace Factorial
{
    internal class Program
    {
        static long Factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }

        static void Main(string[] args)
        {
            int n = 3;

            Console.WriteLine(Factorial(n)); 
        }
    }
}
