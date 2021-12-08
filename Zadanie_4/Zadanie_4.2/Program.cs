using System;

namespace Zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            Recur(n);
            Console.ReadKey(true);
        }

        static void Recur(int n, int step = 0)
        {
            if (step == n) return;
            Console.WriteLine(new string('*', n - step).PadLeft(n));
            Recur(n, step + 1);
        }
    }
    }
    

    