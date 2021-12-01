using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2._1_Practice_WF_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            if (x < 0 && x > 70 && y < 0 && y > 70)
                textBox3.Text = Convert.ToString("Вне");
            else if (x > 0 || x < 70 || y > 70 || y < 0)
                textBox3.Text = Convert.ToString("Внутри");
            else textBox3.Text = Convert.ToString("Внутри"); 
        }
    }
}
