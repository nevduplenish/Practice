using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadanie_9._1_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = int.Parse(textBox1.Text);
            var a = Enumerable.Range(0, n).Select(v => r.NextDouble() * (10 + 10) - 10);
            double average = a.Where((v, i) => i % 2 != 0).Average();
            File.WriteAllText("out.txt", String.Join(" ", a.Select(v => String.Format("{0:0.00}", v))));
            textBox2.Text=Convert.ToString( $"{File.ReadAllText("out.txt").Split(' ').Select(v => double.Parse(v)).Where((v, i) => i % 2 != 0).Average()}");
        }
    }
}

