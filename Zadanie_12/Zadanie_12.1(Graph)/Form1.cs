using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_12._1_Graph_
{
    public partial class Form1 : Form
    {
        Triangle triangle;
        public class Triangle
        {
            public static Triangle triangle;
            // Поля класса Triangle
            public double a = 0;
            public double b = 0;
            public double c = 0;
            public double p = 0;
            public double S = 0;
            // Конструктор класса с передаваемыми аргументами из textBox1,2,3
            public Triangle(double a_, double b_, double c_)
            {
                // присваивание полям значений
                a = a_;
                b = b_;
                c = c_;
            }
            public Triangle()
            {
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
            public double this[double index]
            {
                get
                {
                    switch (index)
                    {
                        case 1:
                            return a;
                        case 2:
                            return b;
                        case 3:
                            return c;
                        default:
                            throw new Exception("Error");
                    }
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
            public string oper(double a, double b, double c)
            {
                a++;
                b++;
                c++;
                string str = "";
                str += Convert.ToString(a);
                str += "\r\n";
                str += Convert.ToString(b);
                str += "\r\n";
                str += Convert.ToString(c);
                str += "\r\n";
                return str;
            }
            public string oper2(double a, double b, double c)
            {
                a--;
                b--;
                c--;
                string str = "";
                str += Convert.ToString(a);
                str += "\r\n";
                str += Convert.ToString(b);
                str += "\r\n";
                str += Convert.ToString(c);
                str += "\r\n";
                return str;
            }
            public string oper3(double a, double b, double c, double s)
            {

                string str = "";
                str += Convert.ToString(a * s);
                str += "\r\n";
                str += Convert.ToString(b * s);
                str += "\r\n";
                str += Convert.ToString(c * s);
                str += "\r\n";
                return str;
            }
            //преобразования типа Triangle в string (и наоборот)
            public static explicit operator String(Triangle tr)
            {
                return tr.a + ", " + tr.b + ", " + tr.c;
            }
            public static explicit operator Triangle(string str)
            {
                string[] q = str.Split(new char[] { ',', ' ' },
               StringSplitOptions.RemoveEmptyEntries);
                Triangle tr = new Triangle();
                tr.a = int.Parse(q[0]);
                tr.b = int.Parse(q[1]);
                tr.c = int.Parse(q[2]);
                return tr;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, s;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            s = Convert.ToDouble(textBox3.Text);
            Triangle obj = new Triangle(a, b, c);
            triangle = new Triangle(a, b, c);
            textBox7.Text = Convert.ToString(triangle.isTriangle.ToString());
            textBox5.Text = Convert.ToString(triangle.AREA_().ToString());
            textBox4.Text = Convert.ToString(triangle.P_().ToString());
            textBox8.Text = Convert.ToString(triangle.oper(a, b, c).ToString());
            textBox9.Text = Convert.ToString(triangle.oper2(a, b, c).ToString());
            textBox10.Text = Convert.ToString(triangle.oper3(a, b, c, s).ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
