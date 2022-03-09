using System;
using System.Collections;

/*
 * Лабораторная работа 7. Интерфейсы
 * Пункт 5 - 6 вариант - создать класс с именованным итератором, который принимает 2 аргумента – start и end.
 * 6)	вывод названий дней недели от start до end.
 */

namespace Project2
{
    class Program
    {
        class Days
        {
            int start;
            int end;
            string[] days;

            public Days(int start, int end)
            {
                this.start = start;
                this.end = end;
                this.days = new string[7] { "Sunday", "Monday", "Tuesday", "Wenstday", "Thursday", "Friday", "Saturday" };
            }

            // Создание именованного итератора
            public IEnumerable ShowDays(int begin, int end)
            {
                for (int i = begin; i <= end; i++)
                {
                    yield return (string)(days[i % 7]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("************************5. Named iterator**********************");
            Console.WriteLine("*********************Days of Weeek*****************************");
            Console.WriteLine("1. Don't forget that the week start by Monday = 1 day, Sunday = 7 day.");
            Console.WriteLine("2. Don't use negative, zero and float numbers.");
            Console.WriteLine("3. If you enter more then 7, the display order will continue.");
            Console.Write("Enter the start of countdown, Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the end of countdown, End: ");
            int end = int.Parse(Console.ReadLine());

            Days weekDays = new Days(start, end);

            Console.Write($"The result of days: ");

            foreach (string day in weekDays.ShowDays(start, end))
            {
                Console.Write(day + " ");
            }

            Console.ReadLine();
        }
    }
}
