using System;

namespace Merge_Sort
{
    internal class Program
    {
        static void Merge(string[] books, int p, int q, int r)
        {
            int i, j, k;

            int n1 = q - p + 1;
            int n2 = r - q;

            string[] booksLeft = new string[n1 + 1];
            string[] booksRight = new string[n2 + 1];

            string max = "Яяя";
           
            for (i = 0; i < n1; i++)
            {
                booksLeft[i] = books[p + i];
            }

            for (j = 1; j <= n2; j++)
            {
                booksRight[j - 1] = books[q + j];
            }
            

            booksLeft[n1] = max;
            booksRight[n2] = max;

            i = 0;
            j = 0;

            for (k = p; k <= r; k++)
            {
                if (booksLeft[i].CompareTo(booksRight[j]) <= 0)
                {
                    books[k] = booksLeft[i];
                    i++;
                    
                }
                else
                {
                    books[k] = booksRight[j];
                    j++;
                }
            }
        }

        static void MergeSort(string[] books, int p, int r)
        {
            int q;

            if (p >= r)
                return;
            else
            {
                q = (r + p) / 2;
                MergeSort(books, p, q);
                MergeSort(books, q + 1, r);
                Merge(books, p, q, r);
            }
        }

        static void Main(string[] args)
        {
            string[] books = { "Пушкин", "Лермонтов", "Грибоедов", "Шекспир", "Гоголь", "Шолохов", "Достоевский" };
            int p = 0, r = books.Length - 1;

            MergeSort(books, p, r);

            foreach (string book in books)
                Console.WriteLine(book);
        }
    }
}
