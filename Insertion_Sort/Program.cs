using System;

namespace Insertion_Sort
{
    internal class Program
    {
        static void InsertionSort(ref string[] books, int length)
        {
            string key;
            int j;

            for (int i = 1; i < length; i++)
            {
                key = books[i];
                j = i - 1;

                while (j >= 0 && books[j].CompareTo(key) > 0)
                {
                    books[j + 1] = books[j];
                    j -= 1;
                }
                books[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            string[] books = { "Пушкин", "Лермонтов", "Грибоедов", "Шекспир", "Гоголь", "Шолохов", "Достоевский" };
            int length = books.Length;

            InsertionSort(ref books, length);

            foreach (string book in books)
                Console.WriteLine(book);
        }
    }
}
