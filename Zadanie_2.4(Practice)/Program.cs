using System;

namespace Zadanie_2._4_Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(j+" ");
                }

                Console.WriteLine();
            }
        }
    }
}