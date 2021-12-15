using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6._1_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 10;

            Random random = new Random();

            int[] arr = new int[10];

            Console.WriteLine("Одномерный массив");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(5, 20);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Индексы одномерного массива больших числа {0}", n);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > n)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Двумерный массив");
            int[,] multyArr = new int[5, 5];

            for (int i = 0; i < multyArr.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr.GetLength(1); j++)
                {
                    multyArr[i, j] = random.Next(5, 20);
                    Console.Write(multyArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Индексы двумерного массива больших числа {0}", n);

            for (int i = 0; i < multyArr.GetLength(0); i++)
            {
                for (int j = 0; j < multyArr.GetLength(1); j++)
                {
                    if (multyArr[i, j] > n)
                    {
                        textBox1.Text = Convert.ToString(i, j);
                    }
                }
            }
        }
    }
}
