using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2._3_Practice_WF_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 4, B = 7;
            int k = A;
            while (k != B + 1)
            {
                if (k >= 0)
                    textBox1.Text = Convert.ToString(k + " ");
                k++;
            }
            k = A;
            do
            {
                if (k >= 0)
                    textBox2.Text = Convert.ToString(k + " ");
                k++;
            }
            while (k != B + 1);
            for (int i = A; i <= B; i++)
            {
                if (i >= 0)
                    textBox3.Text = Convert.ToString(i + " ");
            }
        }
    }
}
