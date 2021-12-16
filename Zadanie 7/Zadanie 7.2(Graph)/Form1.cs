using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_7._2_Graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Vmesto hello world, napishu Privet Pasani!";     //сам текст
            string[] words = text.Split(',', '.', ' ', '!', '?', ';', '-', '/', '*');   //отбираем слова текста
            string shortestWord = words[0];     //само короткое слово
            int smallestLength = words[0].Length;      //значение длины самого короткого слова
            for (int i = 0; i < words.Length; i++)      //ишем короткое слово
            {
                if (words[i] != "" && words[i].Length < smallestLength)
                {
                    smallestLength = words[i].Length;
                    shortestWord = words[i];
                }
            }
            textBox1.Text=Convert.ToString(shortestWord);
        }
    }
}
