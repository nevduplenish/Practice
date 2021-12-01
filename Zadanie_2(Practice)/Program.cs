using System;

namespace Zadanie_2_Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            if (x < 0 && x > 70 && y < 0 && y > 70)
                Console.WriteLine("вне");
            else if (x > 0 || x < 70 || y > 70 || y < 0)
                Console.WriteLine("внутри");
            else Console.WriteLine("на границе");
        }
    }
}
