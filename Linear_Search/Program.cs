using System;

namespace Linear_Search
{
    internal class Program
    {
        static int LinearSearch(ref string[] books, string x, int length)
        {
            int answer = -1;

            for (int i = 0; i < length; i++)
            {
                if (books[i] == x)
                    answer = i;
            }
            return answer;
        }

        static int BetterLinearSearch(ref string[] books, string x, int length)
        {
            for (int i = 0; i < length; i++)
            {
                if (books[i] == x)
                    return i;
            }
            return -1;
        }

        static int SentinelLinearSearch(ref string[] books, string x, int length)
        {
            string last = books[length - 1];
            books[length - 1] = x;

            int i = 0;

            while (books[i] != x)
                i++;

            books[length - 1] = last;

            if (i < length - 1 || books[length - 1] == x)
                return i;
            else
                return -1;
        }

        static int RecursiveLinearSearch(ref string[] books, string x, int length, int i)
        {
            if (i > length - 1)
                return -1;
            else if (i <= length && books[i] == x)
                return i;
            else
                return RecursiveLinearSearch(ref books, x, length, i + 1);
        }

        static void Main(string[] args)
        {
            string[] books = { "Пушкин", "Лермонтов", "Грибоедов", "Шекспир", "Гоголь", "Шолохов", "Достоевский" };
            string x = "Шолохов";
            int length = books.Length;
            int i = 0;

            Console.WriteLine(LinearSearch(ref books, x, length));
            Console.WriteLine(BetterLinearSearch(ref books, x, length));
            Console.WriteLine(SentinelLinearSearch(ref books, x, length));
            Console.WriteLine(RecursiveLinearSearch(ref books, x, length, i));            
        }
    }
}
