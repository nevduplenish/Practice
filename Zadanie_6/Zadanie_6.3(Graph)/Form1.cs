using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6._3_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    int[,] arr = new int[4, 4] { { 12, 10, 0, 1 }, { 43, 55, 57, 67 }, { 4, 3, 1, 2 }, { 13, 0, 15, 16 } };
                    min(arr);
                    count(arr);
                    Console.ReadKey();


                }                
            }

        }
        static void min(int[,] m)
        {
            int sum = 0;
            int minsum = 0;
            int row = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    sum = 0;
                    sum += m[i, j];
                    if (i == 0)
                    {
                        minsum = sum;
                        row = i;
                    }

                }
                if (minsum < sum)
                {
                    minsum = sum;
                    row = i;
                }
            }
            textBox1.Text=Convert.ToString("Норма равна: {0} в столбце {1}", minsum, row);
        }
        static void count(int[,] m)
                {
                    int min = m[0, 0]; int value = 0;
                    for (int i = 0; i < m.GetLength(0); i++)
                        for (int j = 0; j < m.GetLength(1); j++)
                        {

                            if (min > m[i, j])
                            { min = m[i, j]; }

                        }

                    for (int i = 0; i < m.GetLength(0); i++)
                        for (int j = 0; j < m.GetLength(1); j++)
                        {
                            if (min == m[i, j])
                                value += 1;
                        }

                }
    }
}
