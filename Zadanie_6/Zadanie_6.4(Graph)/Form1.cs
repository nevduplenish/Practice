using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6._4_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 10;
            Random rnd = new Random();
            int[][] ar = new int[n][];
            for (int i = 0; i < n; i++)
            {
                ar[i] = new int[n];
                for (int j = 0; j < n; j++)
                    ar[i][j] = rnd.Next(-100, 100);
            }

            foreach (int[] row in ar)
            {
                foreach (int element in row)
                {
                    Console.Write(element.ToString() + " ");
                }
                Console.WriteLine();
            }
            int[] num = new int[n];
            for (int i = 0; i < n; i++)
            {
                num[i] = -1;
                for (int j = 0; j < n; j++)
                {
                    if (ar[i][j] < 0)
                    {
                        num[i] = j;
                        break;
                    }
                }
            }
            Console.Write("\n");
            for (int j = 0; j < n; j++)
                textBox1.Text=Convert.ToString(String.Format(" {0} ", num[j]));
            Console.Write("\n");
        }
    }
}
