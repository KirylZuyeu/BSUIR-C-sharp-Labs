using System;
using System.Text.RegularExpressions;

/*
 * Лабораторная работа 2. Работа со строками
 * Задание 3. Работа с регулярными выражениями.
 * Написать метод, решающий поставленную задачу. Типы параметров и результата определить самостоятельно. Использовать регулярные выражения.
 * Вариант 6
 * 1. Удалить из сообщения все однобуквенные слова (вместе с лишними пробелами). 
 */

namespace Project3
{
    class Task2_3
    {

        static string message;

        static void initMessage()
        {
            Console.Write("Enter the string to change: ");
            message = Convert.ToString(Console.ReadLine());
        }

        static string deleteExtra(string line)
        {
            string pattern = @"\b\w\b\W*";
            string substitution = @"";
            RegexOptions options = RegexOptions.CultureInvariant;

            Regex regex = new Regex(pattern, options);
            string result = regex.Replace(line, substitution);

            return result;
        }
        static void Main()
        {
            string resultMessage;
            initMessage();
            resultMessage = deleteExtra(message);
            Console.WriteLine($"The resulting string, (resultLine): {resultMessage}");
        }
    }
}
