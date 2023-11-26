using System;

namespace Selection_Sort
{
    internal class Program
    {
        static void SelectionSort(ref string[] books, int length)
        {
            int smallest;
            string temp;

            for (int i = 0; i < length - 1; i++)
            {
                smallest = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (books[j].CompareTo(books[smallest]) < 0)
                        smallest = j;
                }

                if (smallest != i)
                {
                    temp = books[i];
                    books[i] = books[smallest];
                    books[smallest] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            string[] books = { "Пушкин", "Лермонтов", "Грибоедов", "Шекспир", "Гоголь", "Шолохов", "Достоевский" };
            int length = books.Length;

            SelectionSort(ref books, length);

            foreach (string book in books)
                Console.WriteLine(book);
        }
    }
}
