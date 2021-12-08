using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4_Graph_
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
            textBox1.Text=Convert.ToString(F(1));
            textBox2.Text = Convert.ToString(F(2));
        }
        static double F(int n)
        {
            if (n == 1) return 5;
            return F(n - 1) / (n * n + n + 1);
        }
    }
}
