using System;

namespace Compute_LSC_Table
{
    internal class Program
    {
        static int[,] ComputeLSCTable(string x, string y)
        {
            int[,] l = new int[x.Length + 1, y.Length + 1];
            
            for (int i = 0; i < x.Length; i++)
                l[i, 0] = 0;

            for (int j = 0; j < y.Length; j++)
                l[0, j] = 0;
            
            for (int i = 1; i <= x.Length; i++)
            {
                for (int j = 1; j <= y.Length; j++)
                {
                    if (x[i - 1] == y[j - 1])
                        l[i, j] = l[i - 1, j - 1] + 1;
                    else
                        l[i, j] = l[i - 1, j] > l[i, j - 1] ? l[i - 1, j] : l[i, j - 1];
                }
            }
            return l;
        }

        static string AssembleLCS(string x, string y, int[,] l, int i, int j)
        {
            if (l[i, j] == 0)
                return string.Empty;
            else if (x[i - 1] == y[j - 1])
                return AssembleLCS(x, y, l, i - 1, j - 1) + x[i - 1];
            else if (l[i, j - 1] > l[i - 1, j])
                return AssembleLCS(x, y, l, i, j - 1);
            else
                return AssembleLCS(x, y, l, i - 1, j);
        }

        static void Main(string[] args)
        {
            string x = "CATCGA";
            string y = "GTACCGTCA";

            int[,] l = ComputeLSCTable(x, y);

            string result = AssembleLCS(x, y, l, x.Length, y.Length);
            Console.WriteLine(result);

        }
    }
}
