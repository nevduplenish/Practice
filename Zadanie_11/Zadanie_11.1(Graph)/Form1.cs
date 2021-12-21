using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_11._1_Graph_
{
    public partial class Form1 : Form
    {
            Triangle triangle;
            public Form1()
            {
                InitializeComponent();
            }
            private void button1_Click(object sender, EventArgs e)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                triangle = new Triangle(a, b, c);
                textBox6.Text = triangle.isTriangle.ToString();
                textBox4.Text = triangle.AREA_().ToString();
                textBox5.Text = triangle.P_().ToString();
            }
            public class Triangle
            {
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
            }
            private void button2_Click(object sender, EventArgs e)
            {
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text =
               ""; textBox5.Text = ""; textBox6.Text = "";
            }
        

    }
}
