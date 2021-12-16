using System;

namespace Zadanie_7._2
{
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine(shortestWord);
        }
    }
}
