using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3._1_Graphics_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int x = int.Parse(textBox1.Text);
                if ((x > 999) || (x < 100))
                    textBox3.Text=Convert.ToString("Вы ввели не трехзначное число!");
                else
                    textBox3.Text=Convert.ToString(res(x.ToString()));
        }
        static string res(string s)
        {
            char[] n = s.ToArray();
            n = n.Reverse().ToArray();
            string str = null;
            foreach (char ch in n)
                str = string.Concat(str, ch);
            return str;
        }
    }
}
