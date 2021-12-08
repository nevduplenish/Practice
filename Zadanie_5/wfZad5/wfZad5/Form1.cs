using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfZad5
{
    public partial class Form1 : Form
    {
        static string f(double a, double b, double h)
        {
            string str = "";
            for (double x = a; x <= b; x += h)
            {
                if ((x * x * x * x - 1) < 0 || (1 + x) < 0)
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(tbA.Text);
                double b = Double.Parse(tbB.Text);
                double h = Double.Parse(tbH.Text);
                labRes.Text = "Результат: " + f(a, b, h);
            }
            catch (System.FormatException)
            {
                labRes.Text = "Введено не число!";
            }
            catch (Exception exc)
            {
                labRes.Text = exc.Message;
            }
        }
    }
}
