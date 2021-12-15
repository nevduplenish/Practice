using System;

namespace Zadanie_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            Random random = new Random();

            int[] arr = new int[10];

            Console.WriteLine("Одномерный массив");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(5, 20);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Индексы одномерного массива больших числа {0}", n);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > n)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Двумерный массив");
            int[,] multyArr = new int[5, 5];

            for (int i = 0; i < multyArr.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr.GetLength(1); j++)
                {
                    multyArr[i, j] = random.Next(5, 20);
                    Console.Write(multyArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Индексы двумерного массива больших числа {0}", n);

            for (int i = 0; i < multyArr.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr.GetLength(1); j++)
                {
                    if (multyArr[i, j] > n)
                    {
                        Console.WriteLine("{0} {1} ", i, j);
                    }
                }
            }
        }
    }
}
