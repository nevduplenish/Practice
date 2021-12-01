    using System;

    namespace Zadanie_2._2__Practice_
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите номер дня недели,где\n");
                Console.WriteLine("1 - Понедельник\n");
                Console.WriteLine("2 - Вторник\n");
                Console.WriteLine("3 - Среда\n");
                Console.WriteLine("4 - Четверг\n");
                Console.WriteLine("5 - Пятница\n");
                Console.WriteLine("6 - Суббота\n");
                int choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Расписание врача в понедельник 9-00 до 14-00");
                        break;
                    case 2:
                        Console.WriteLine("Расписание врача в вторник 8-00 до 12-00");
                        break;
                    case 3:
                        Console.WriteLine("Расписание врача в среду  8-00 до 14-00");
                        break;
                    case 4:
                        Console.WriteLine("Расписание врача в четверг 8-00 до 15-00");
                        break;
                    case 5:
                        Console.WriteLine("Расписание врача в пятницу 8-00 до 11-00");
                        break;
                    case 6:
                        Console.WriteLine("Расписание врача в субботу 9-00 до 12-00");
                        break;
                    default:
                        Console.WriteLine("Неверно введен номер дня недели");
                        break;
                }
            }
        }
    }
