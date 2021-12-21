using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Zadanie_10._1
{
    class Task10
    {
        string str1 = "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов";
        string str2 = "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс";
        public Task10()
        {
            CreateDirectories();
            CreateTxt();
            ReplaceNCopy();
            RenameNDelete();
        }
        void CreateDirectories()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp");
            directory.CreateSubdirectory(@"K1");
            directory.CreateSubdirectory(@"K2");
        }
        void CreateTxt()
        {
            File.WriteAllText(@"C:\Temp\K1\t1.txt", str1);
            File.WriteAllText(@"C:\Temp\K1\t2.txt", str2);
            string asd = File.ReadAllText(@"C:\Temp\K1\t1.txt") + '\n';
            asd += File.ReadAllText(@"C:\Temp\K1\t2.txt");
            File.WriteAllText(@"C:\Temp\K2\t3.txt", asd);
        }
        public string GetFileInfo()
        {
            string res = String.Empty;
            FileInfo fileInfo = new FileInfo(@"C:\Temp\K1\t1.txt");
            res += "Имя первого файла: " + fileInfo.Name + '\n';
            res += "Время создание первого файла: " + fileInfo.CreationTime.ToString() + '\n';
            res += "Размер первого файла: " + fileInfo.Length.ToString() + '\n' + '\n';
            fileInfo = new FileInfo(@"C:\Temp\K1\t2.txt");
            res += "Имя второго файла: " + fileInfo.Name + '\n';
            res += "Время создание второго файла: " + fileInfo.CreationTime.ToString() + '\n';
            res += "Размер второго файла: " + fileInfo.Length.ToString() + '\n' + '\n';
            fileInfo = new FileInfo(@"C:\Temp\K2\t3.txt");
            res += "Имя третьего файла: " + fileInfo.Name + '\n';
            res += "Время создание третьего файла: " + fileInfo.CreationTime.ToString() + '\n';
            res += "Размер третьего файла: " + fileInfo.Length.ToString() + '\n' + '\n';
            return res;
        }
        void ReplaceNCopy()
        {
            File.Move(@"C:\Temp\K1\t2.txt", @"C:\Temp\K2\t2.txt");
            File.Copy(@"C:\Temp\K1\t1.txt", @"C:\Temp\K2\t1.txt");
        }
        void RenameNDelete()
        {
            Directory.Move(@"C:\Temp\K2", @"C:\Temp\All");
            DirectoryInfo directory = new DirectoryInfo(@"C:\Temp\K1");
            directory.Delete(true);
        }
        public string GetDirectoryInfo()
        {
            string res = String.Empty;
            string[] files = Directory.GetFiles(@"C:\Temp\All");
            foreach (string s in files)
            {
                FileInfo fileInfo = new FileInfo(s);
                res += "Имя файла: " + fileInfo.Name + '\n';
                res += "Время создание файла: " + fileInfo.CreationTime.ToString() + '\n';
                res += "Размер файла: " + fileInfo.Length.ToString() + '\n' + '\n';
            }
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Task10 t = new Task10();
                Console.WriteLine(t.GetDirectoryInfo());
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("Удалите папки и снова запустите программу");
            }

        }
    }
}
