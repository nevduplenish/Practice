using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Zadanie_8._1_Graph_
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
            {
                try
                {

                    string str = textBox1.Text;
                    Class1 o = new Class1(str);
                    textBox2.Text=Convert.ToString(o.Result);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
        class Class1
        {
            string pattern = @"(?<day>0?[1-9]|[12][0-9]|3[01])(?>.{1})(?(?=0?[469]|11)(?<!31(?>.{1}))|)(?(?=0?2)(?<!3[01](?>.{1})))(?(?=0?2(?>.{1})\d\d(?!00)(?:[02468][048]|[13579][26]))|(?<!29(?>.{1})))(?<month>0?[1-9]|1[12])(?>.{1})(?<year>19[0-9][0-9]|20[0-9][0-9]|[0-9]{2,4})(?!\d)";
            string result = String.Empty;
            public Class1(string str)
            {
                Regex newReg = new Regex(pattern);
                MatchCollection matches = newReg.Matches(str);
                foreach (Match mat in matches)
                {
                    result += mat.Value + '\n';
                }
            }
            public string Result
            {
                get
                {
                    return result;
                }
            }
        }
    }
}
