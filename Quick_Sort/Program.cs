using System;

namespace Quick_Sort
{
    internal class Program
    {
        static void QuickSort(string[] books, int p, int r)
        {
            int q;

            if (p >= r)
                return;
            else
            {
                q = Partition(books, p, r);
                QuickSort(books, p, q - 1);
                QuickSort(books, q + 1, r);
            }
        }

        static int Partition(string[] books, int p, int r)
        {
            int q = p;
            string temp;
            for (int u = p; u <= r-1; u++)
            {
                if (books[u].CompareTo(books[r]) <= 0)
                {
                    temp = books[q];
                    books[q] = books[u];
                    books[u] = temp;
                    q++;
                }
            }

            temp = books[r];
            books[r] = books[q];
            books[q] = temp;
            return q;
        }

        static void Main(string[] args)
        {
            string[] books = { "Пушкин", "Лермонтов", "Грибоедов", "Шекспир", "Гоголь", "Шолохов", "Достоевский" };
            int p = 0, r = books.Length - 1;

            QuickSort(books, p, r);

            foreach (string book in books)
                Console.WriteLine(book);
        }
    }
}
