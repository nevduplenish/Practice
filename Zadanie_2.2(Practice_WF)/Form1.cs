using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_2._2_Practice_WF_
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int choose = Int32.Parse(textBox1.Text);
            switch (choose)
            {
                case 1:
                    textBox2.Text = Convert.ToString("Расписание врача в понедельник 9-00 до 14-00");
                    break;
                case 2:
                    textBox2.Text = Convert.ToString("Расписание врача в вторник 8-00 до 12-00");
                    break;
                case 3:
                    textBox2.Text = Convert.ToString("Расписание врача в среду  8-00 до 14-00");
                    break;
                case 4:
                    textBox2.Text = Convert.ToString("Расписание врача в четверг 8-00 до 15-00");
                    break;
                case 5:
                    textBox2.Text = Convert.ToString("Расписание врача в пятницу 8-00 до 11-00");
                    break;
                case 6:
                    textBox2.Text = Convert.ToString("Расписание врача в субботу 9-00 до 12-00");
                    break;
                default:
                    textBox2.Text = Convert.ToString("Неверно введен номер дня недели");
                    break;
            }
        }
    }
}
