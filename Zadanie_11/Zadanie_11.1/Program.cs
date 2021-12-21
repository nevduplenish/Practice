using System;

namespace Zadanie_1._1
{
    public class Triangle
    {
        public static Triangle triangle;
      
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double p = 0;
        public double S = 0;
  
        public Triangle(double a_, double b_, double c_)
        {
            a = a_;
            b = b_;
            c = c_;
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public bool isTriangle
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
                return false;
            }
        }
        public double P_()
        {
            p = (A + B + C) / 2;
            return p;
        }
        public double AREA_()
        {
            double P = P_();
            S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треуголинка");
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());
            triangle = new Triangle(a, b, c);
            Console.WriteLine("Существует ли треугольник");
            Console.WriteLine(triangle.isTriangle.ToString());
            Console.WriteLine("Площадь");
            Console.WriteLine(triangle.AREA_().ToString());
            Console.WriteLine("Периметр");
            Console.WriteLine(triangle.P_().ToString());
        }
    }
}
