using System;

namespace Zadanie_2._3_Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 4, B = 7;
            int k = A;
            while (k != B + 1)
            {
                if (k >= 0)
                    Console.Write(k + " ");
                k++;
            }
            k = A;
            Console.WriteLine("while");
            do
            {
                if (k >= 0)
                    Console.Write(k + " ");
                k++;
            }
            while (k != B + 1);
            Console.WriteLine("do while");
            for (int i = A; i <= B; i++)
            {
                if (i >= 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine("for");
        }
    }
}
