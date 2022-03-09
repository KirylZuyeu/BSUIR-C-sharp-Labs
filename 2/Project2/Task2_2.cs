using System;
using System.Text;

/*
 * Лабораторная работа 2. Работа со строками
 * Задание 2. Работа с классом StringBuilder.
 * Написать метод, который принимает несколько строк (использовать params). 
 * Для каждой строки выполнить индивидуальное задание (в цикле). 
 * Объединить строки в одну, используя разделитель ";" и уменьшить емкость буфера до реального размера полученной строки. 
 * Метод возвращает размер буфера. Результирующая строка возвращается через параметр out.
 * Вариант 6
 * 1. Удалить все подстроки substr;
 */

namespace Project2
{
    class Task2_2
    {
        static string firstLine;
        static string secondLine;
        static string substr;

        static void initTask()
        {
            Console.Write("Enter the first Line for this Task, (firstLine): ");
            firstLine = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the first Line for this Task, (secondLine): ");
            secondLine = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the substring to remove, (substr): ");
            substr = Convert.ToString(Console.ReadLine());
        }

        static int taskMainFunction(out StringBuilder resultLine, params string[] lines)
        {
            string joinKey = ";";
            string removeKey = "";

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(substr, removeKey);
            }

            StringBuilder stringBuilder = new StringBuilder(string.Join(joinKey, lines));
            resultLine = stringBuilder;
            return resultLine.Length;
        }

        static void Main()
        {
            initTask();
            int bufferСapacity = taskMainFunction(out StringBuilder resultLine, firstLine, secondLine);
            Console.WriteLine($"The bufferСapacity has following size, (bufferСapacity): {bufferСapacity}");
            Console.WriteLine($"The resulting string looks on following, (resultLine): {resultLine}");
        }
    }
}
