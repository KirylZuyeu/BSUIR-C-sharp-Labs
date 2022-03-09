using System;

/*
 * Лабораторная работа 1. Работа с массивами 
 * Задание 3. Зубчатый массив
 * Ввести с клавиатуры размерность массива, минимальное и максимальное значение.
 * Создать зубчатый массив. (Длина каждой строки выбирается случайным образом от 1 до n)
 * Заполнить массив случайными числами в диапазоне от минимального до максимального значения. 
 * Вывести полученный массив.
 * Выполнить индивидуальное задание. (При необходимости, запросить у пользователя необходимые данные. Вывести преобразованный массив.
 * Вариант 6
 * Для каждого столбца подсчитать сумму отрицательных элементов и записать данные в новый массив. Если в строке данный столбец отсутствует, считать элемент равным 0.
 */

namespace Project3
{
    class Task3
    {
        static int size, min, max;

        static void initArray()
        {
            Console.Write("Enter the size of the jagged array (size): ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the lowest value for each element of jagged array (min): ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the lowest value for each element of jagged array (max): ");
            max = Convert.ToInt32(Console.ReadLine());
        }

        static int[][] createJaggedArray(int size)
        {
            return new int[size][];
        }

        static void fillArray(int[][] arr, int size, int minBorder, int maxBorder)
        {
            Random rand = new Random();
            Console.Write("Enter the max Number of elements in each jag (n): ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                arr[i] = new int[rand.Next(1, n)];
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(min, max);
                }
            }
        }

        static void printJaggedArray(int[][] array, int size)
        {
            Console.WriteLine("************************Source Jagged Array*************************");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************************************");
        }

        static int[] sumOfNegativeForEachJad(int[][] array, int size)
        {
            int[] resultArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                int sumOfNegative = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] < 0)
                    {
                        sumOfNegative = sumOfNegative + array[i][j];
                    }
                }
                resultArray[i] = sumOfNegative;
            }

            return resultArray;
        }

        static void printArray(int[] array)
        {
            Console.WriteLine("***********Array of Sum with Negative Elements in Each Jad***********");
            Console.WriteLine($"[{string.Join(", ", array)}]");
            Console.WriteLine("*********************************************************************");
        }

        static void Main()
        {
            int[][] array;
            
            initArray();
            array = createJaggedArray(size);
            fillArray(array, size, min, max);
            printJaggedArray(array, size);
            int[] resultArray = sumOfNegativeForEachJad(array, size);
            Console.WriteLine();
            printArray(resultArray);
        }
    }
}
