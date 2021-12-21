using System;
using System.Linq;
using System.IO;

namespace Zadanie_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            var a = Enumerable.Range(0, n).Select(v => r.NextDouble() * (10 + 10) - 10);
            double average = a.Where((v, i) => i % 2 != 0).Average();
            File.WriteAllText("out.txt", String.Join(" ", a.Select(v => String.Format("{0:0.00}", v)))); 
            Console.WriteLine($"Среднее арифметическое элементов на чётных позициях = " +
                $"{File.ReadAllText("out.txt").Split(' ').Select(v => double.Parse(v)).Where((v, i) => i % 2 != 0).Average()}");
            Console.ReadKey();
        }
    }
}