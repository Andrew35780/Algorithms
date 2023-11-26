using System;

namespace Count_Keys_Equal
{
    internal class Program
    {
        static int[] CountKeysEqual(int[] array, int n, int m)
        {
            int[] equal = new int[m];
            int key;

            for (int i = 0; i < n; i++)
            {
                key = array[i];
                equal[key] += 1;
            }

            return equal;
        }

        static int[] CountKeysLess(int[] equal, int m)
        {
            int[] less = new int[m];
            less[0] = 0;

            for (int j = 1; j < m; j++)
                less[j] = less[j - 1] + equal[j - 1];

            return less;
        }

        static int[] RearRange(int[] array, int[] less, int n, int m)
        {
            int[] B = new int[n];
            int[] next = new int[m];
            int key;
            int index;

            for (int j = 0; j < m; j++)
                next[j] = less[j] + 1;

            for (int i = 0; i < n; i++)
            {
                key = array[i];
                index = next[key];
                B[index - 1] = array[i];
                next[key] += 1;
            }

            return B;
        }

        static int[] Counting_Sort(int[] array, int n, int m)
        {
            int[] equal = CountKeysEqual(array, n, m);

            int[] less = CountKeysLess(equal, m);

            int[] B = RearRange(array, less, n, m);

            return B;
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 1, 5, 0, 1, 6, 5, 1, 5, 3 };
            int n = array.Length;
            int m = 7;

            foreach (int i in Counting_Sort(array, n, m))
               Console.WriteLine(i);
        }
    }
}
