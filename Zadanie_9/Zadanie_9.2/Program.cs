using System;
using System.Linq;
using System.IO;


namespace Zadanie_9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            using (StreamReader sr = new StreamReader("c:\\1.txt"))
            {
                string tmp;
                while (!sr.EndOfStream)
                {
                    tmp = sr.ReadLine();
                    if (tmp.Length < n)
                    {
                        Console.WriteLine(tmp);
                    }
                }
            }
        }     
                
    }
}

