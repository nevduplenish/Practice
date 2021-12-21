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

namespace Zadanie_9._2_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            using (StreamReader sr = new StreamReader("c:\\1.txt"))
            {
                string tmp;
                while (!sr.EndOfStream)
                {
                    tmp = sr.ReadLine();
                    if (tmp.Length < n)
                    {
                        textBox2.Text=Convert.ToString(tmp);
                    }
                }
            }
        }
    }
}
