using System;

namespace Zadanie_4._1
{
    class Program
    {
        static double F(int n)
        {
            if (n == 1) return 5; 
            return F(n - 1) / (n * n + n + 1); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(F(1)); 
            Console.WriteLine(F(2)); 
        }
    }
}
