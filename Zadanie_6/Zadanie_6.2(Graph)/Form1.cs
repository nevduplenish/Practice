using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_6._2_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 3, 6, 8, -3, -56, 986, 54, -52, 54 };
            int max = array[0];
            int numbermax = 0;
            Console.WriteLine("Исходный массив:");
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    numbermax = i;
                }
            }
            Console.WriteLine("Максимальный элемент:" + max + "." + "Позиция в массиве:" + (numbermax + 1));
            int min = array[0];
            int numbermin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    numbermin = i;
                }
            }
            Console.WriteLine("Минимальный элемент:" + min + "." + "Позиция в массиве:" + (numbermin + 1));

            for (int i = 0; i < array.Length; i++)
            {
                int a, b;
                a = array[numbermin];
                b = array[numbermax];
                array[numbermin] = b;
                array[numbermax] = a;
            }
            Console.WriteLine("Полученный массив:");
            foreach (int i in array)
            {
                richTextBox1.Text=Convert.ToString(i + " ");
            }
        }
    }
}
