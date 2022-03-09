using System;

/*
 * Лабораторная работа 1. Работа с массивами 
 * Задание 1. Одномерный массив целых чисел.
 * Ввести с клавиатуры размерность массива, минимальное и максимальное значение.
 * Создать одномерный массив и заполнить его случайными числами в диапазоне от минимального до максимального значения.
 * Вывести полученный массив.
 * Выполнить индивидуальное задание. (При необходимости, запросить у пользователя необходимые данные. Вывести преобразованный массив.
 * Вариант 6
 * 1. Подсчитать среднее арифметическое отрицательных элементов.
 * 2. Найти номер (индекс) первого минимального элемента.
 */

namespace Project1
{
    class Task1
    {
        static int n, min, max;

        static void initArray()
        {
            Console.Write("Enter the dimension of the array (n): ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the lowest value of the array (min): ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the highest value of the array (max): ");
            max = Convert.ToInt32(Console.ReadLine());
        }

        static int[] createArray(int arrSize, int minBorder, int maxBorder)
        {
            int[] arr = new int[arrSize];
            Random rand = new Random();
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = rand.Next(minBorder, maxBorder);
            }
            return arr;
        }

        static void printArray(int[] array)
        {
            Console.WriteLine("***********Source Array***********");
            Console.WriteLine($"[{string.Join(", ", array)}]");
            Console.WriteLine("**********************************");
        }

        static void getAverageNegative(int[] arr)
        {
            double sum = 0;
            int amountNegative = 0;
            double average;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                    amountNegative++;
                }
            }

            if (amountNegative != 0)
            {
                average = sum / amountNegative;
                Console.WriteLine($"Average of the negative elements equals, AverageNegative = {average}");
            } 
            else
            {
                Console.WriteLine("The array doesn't contain negative elements");
            }           
        }

        static void getFirstMinValue(int[] arr)
        {
            int minvalue;
            int index;

            index = 0;
            minvalue = arr[index];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minvalue)
                {
                    minvalue = arr[i];
                    index = i;
                }
            }

            Console.WriteLine($"The lowest value of the array, LowestValue = {minvalue}");
            Console.WriteLine($"The index of the first lowest value of the array, IndexFirstLowest = {index}");
        }

        static void Main()
        {
            int[] array;
            initArray();
            array = createArray(n, min, max);
            printArray(array);
            getAverageNegative(array);
            getFirstMinValue(array);
        }
    }
}

