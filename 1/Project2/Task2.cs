using System;

/*
 * Лабораторная работа 1. Работа с массивами 
 * Задание 2. Квадратный массив.
 * Ввести с клавиатуры размерность массива, минимальное и максимальное значение.
 * Создать квадратный массив и заполнить его случайными числами в диапазоне от минимального до максимального значения.
 * Вывести полученный массив.
 * Выполнить индивидуальное задание. (При необходимости, запросить у пользователя необходимые данные. Вывести преобразованный массив.
 * Вариант 6
 * Поменять местами две средних строки, если количество строк четное, и первую со средней строкой, если количество строк нечетное.
 */

namespace Project2
{
    class Task2
    {
        static int rows, columns, min, max;

        static void initArray()
        {
            Console.Write("Enter the number of rows of the array (rows): ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns of the array (columns): ");
            columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the lowest value of the array (min): ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the highest value of the array (max): ");
            max = Convert.ToInt32(Console.ReadLine());
        }

        static int[,] createArray(int numRows, int numColumns, int minBorder, int maxBorder)
        {
            int[,] arr = new int[numRows, numColumns];
            Random rand = new Random();
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    arr[i, j] = rand.Next(minBorder, maxBorder);
                }
            }
            return arr;
        }

        static void printArray(int[,] array)
        {
            int rowLength = array.GetLength(0);
            int colLength = array.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static int[,] cloneArray(int[,] array)
        {
            int[,] copyArray = (int[,])array.Clone();
            return copyArray;
        }

        static void changeRows(int[,] arr, int numRows, int numColumns)
        {
            int tmb;
            if (numRows % 2 == 0)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    tmb = arr[(numRows / 2), j];
                    arr[(numRows / 2), j] = arr[(numRows / 2) - 1, j];
                    arr[(numRows / 2 - 1), j] = tmb;
                }
            }
            else
            {
                for (int j = 0; j < numColumns; j++)
                {
                    tmb = arr[((numRows - 1) / 2), j];
                    arr[((numRows - 1) / 2), j] = arr[0, j];
                    arr[0, j] = tmb;
                }
            }
        }

        static void Main()
        {
            int[,] array;
            int[,] copyArray;
            initArray();
            array = createArray(rows, columns, min, max);
            Console.WriteLine("***********Source Multidimensional Array***********");
            printArray(array);
            Console.WriteLine("**********************************");
            //Making copy of the array
            copyArray = cloneArray(array);
            changeRows(copyArray, rows, columns);
            printArray(copyArray);
        }
    }
}
