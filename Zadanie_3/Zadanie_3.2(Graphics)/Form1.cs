using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3._2_Graphics_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);
            for (double i = a; i <= b; i += h)
                textBox4.Text=Convert.ToString (i);
        }
        static double f(double x, out double y)
        {
            if (x < 0) y = 0;
            else if (x >= 0 && x != 0) y = x * x + 1;
            else y = 1;
            return y;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


