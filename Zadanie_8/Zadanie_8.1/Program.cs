using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Zadanie_8._1
{



    class Program
    {
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
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.WriteLine("Вводите слова через пробел: ");
                    string str = Console.ReadLine();
                    Class1 o = new Class1(str);
                    Console.WriteLine("Результат:\n{0}", o.Result);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
    }
}
