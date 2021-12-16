using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Zadanie_7._1_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Пиво - 70 рублей, водка - 302 рубля, стакан - 33 рубля.";

            int digitsIn = text.Count(char.IsDigit);

            string newText = Regex.Replace(text, @"\w+я", "", RegexOptions.IgnoreCase);

            textBox1.Text=Convert.ToString(digitsIn);
        }
    }
}
