using System;

/*
 * Лабораторная работа 2. Работа со строками 
 * Задание 1. Работа с классом string.
 * Написать метод, который получает строку и возвращает результат.(Не использовать регулярные выражения.)
 * Вариант 6
 * 1. Удвоить каждое вхождение заданного символа x;
 */

namespace Project1
{
    class Task2_1
    {
        static string text;
        static char key;
        static void initOfTask()
        {
            Console.Write("Enter the string to change: ");
            text = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the key letter that will be duplicated: ");
            key = Convert.ToChar(Console.ReadLine());
        }

        static bool isKey(char ch)
        {
            return (ch == key);
        }

        static String duplicateLetter(String text)
        {
            int t = text.Length;

            String res = "";

            for (int i = 0; i < t; i++)
            {
                if (isKey(text[i]))
                {
                    res += text[i];
                }
                res += text[i];

            }
            return res;
        }

        static void Main()
        {
            string resultString;
            initOfTask();
            resultString = duplicateLetter(text);
            Console.WriteLine($"The result of the modified string: {resultString}");

        }
    }
}
