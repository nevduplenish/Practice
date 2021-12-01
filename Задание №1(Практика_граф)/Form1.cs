using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание__1_Практика_граф_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                {
                int x1 = Convert.ToInt32(textBox1.Text);
                int x2 = Convert.ToInt32(textBox2.Text);
                int x3 = Convert.ToInt32(textBox3.Text);
                    if (x1 > x3)
                        textBox4.Text = Convert.ToString("Первая цифра в числе " + x1 + x2 + x3 + " больше третьей");
                    else
                        textBox4.Text = Convert.ToString("Третья цифра в числе " + x1 + x2 + x3 + " больше первой");
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
