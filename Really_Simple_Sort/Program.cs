using System;

namespace Really_Simple_Sort
{
    internal class Program
    {
        static void ReallySimpleSort(int[] array, int n)
        {
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] == 1)
                    k++;
            }

            for (int i = 0; i < k; i++)
                array[i] = 1;

            for (int i = k + 1; i < n; i++)
                array[i] = 2;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 1, 1, 2, 1, 2, 1, 1, 1, 2, 2, 2, 1, 1, 2, 1 };
            int n = array.Length;

            ReallySimpleSort(array, n);

            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
