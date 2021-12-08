using System;

namespace cZad5
{
    class Program
    {
        static string f(double a, double b, double h)
        {
            string str = "";
            for (double x = a; x<=b; x+=h)
            {
                if ((x*x*x*x - 1)<0 || (1+x)<0)
                {
                    throw new Exception("Ошибка: логарифм отрицательного числа");
                }
                else if ((x * x * x * x - 1) == 0 || (1 + x) == 0)
                {
                    throw new Exception("Ошибка: логарим нуля");
                }
                else                
                {
                    str += (Math.Log(x * x * x * x - 1) * Math.Log(1 + x)) + " ";
                }
            }
            return str;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите a: ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write("Введите b: ");
                double b = Double.Parse(Console.ReadLine());
                Console.Write("Введите h: ");
                double h = Double.Parse(Console.ReadLine());
                Console.WriteLine("Результат: {0}", f(a, b, h));
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Введено не число!");
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
