using System;

namespace Binary_Search
{
    internal class Program
    {
        static int BinarySearch(ref string[] books, string x, int length)
        {
            int p = 0;
            int q;
            int r = length;
            while (p <= r)
            {
                q = (p + r) / 2;
                if (string.Compare(books[q], x, true) == 0)
                    return q;
                else if (string.Compare(books[q], x, true) > 0)
                    r = q - 1;
                else
                    p = q + 1;
            }
            return -1;
        }

        static int RecursiveBinarySearch(ref string[] books, string x, int p, int r)
        {
            int q;

            if (p > r)
                return -1;
            else
            {
                q = (int)(p + r) / 2;
                if (books[q] == x)
                    return q;
                else if (string.Compare(books[q], x, true) > 0)
                    return RecursiveBinarySearch(ref books, x, p - 1, r);
                else
                    return RecursiveBinarySearch(ref books, x, p + 1, r);
            }
        }

        static void Main(string[] args)
        {
            string[] books = { "Пушкин", "Лермонтов", "Грибоедов", "Шекспир", "Гоголь", "Шолохов", "Достоевский" };
            string x = "Шолохов";
            int length = books.Length - 1;
            int p = 0;
            int r = length;

            Array.Sort(books);

            Console.WriteLine(BinarySearch(ref books, x, length));
            Console.WriteLine(RecursiveBinarySearch(ref books, x, p, r));
        }
    }
}
