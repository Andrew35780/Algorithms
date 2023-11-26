using System;

namespace Heap_Sort
{
    internal class Program
    {
        static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                (arr[i], arr[0]) = (arr[0], arr[i]);
                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;

            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[largest], arr[i]) = (arr[i], arr[largest]);
                Heapify(arr, n, largest);
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 5, 2, 7, 0, 6, 3, 4, 8 };

            Sort(array);

            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
