using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4._2_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 15;
            Recur(n);
        }
        static void Recur(int n, int step = 0)
        {
            if (step == n) return;
            TextBox1.Text=Convert.ToString(new string('*', n - step).PadLeft(n));
            Recur(n, step + 1);
        }
    }
}
