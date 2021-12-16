using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Zadanie_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Пиво - 70 рублей, водка - 302 рубля, стакан - 33 рубля.";

            int digitsIn = text.Count(char.IsDigit);

            string newText = Regex.Replace(text, @"\w+я", "", RegexOptions.IgnoreCase);

            Console.WriteLine(text + Environment.NewLine);
            Console.WriteLine("Кол-во цифр в строке - {0}", digitsIn);


            Console.ReadKey();
        }
    }
}
