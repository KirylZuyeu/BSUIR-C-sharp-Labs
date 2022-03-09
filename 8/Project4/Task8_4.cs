using System;
using System.Linq;

/*
 * 8.4. LINQ с массивом
 * Создайте массив из 30 элементов типа int. Заполните его случайными числами. 
 * Выберите диапазон случайных чисел, оптимальный для решаемой задачи. 
 * Выполните задание, используя сначала запрос LINQ, а затем метод расширения (лямбда-выражение).
 * Вариант - 6) Определить минимум среди четных положительных чисел.
*/

namespace Project4
{
    class Task8_4
    {
        static void printArray(int[] array)
        {
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static void Main(string[] args)
        {
            Console.Write($"Введите минимальное значение диапазона, Min: ");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите максимальное значение диапазона, Max: ");
            int Max = Convert.ToInt32(Console.ReadLine());
            int[] ArrayIntegers = new int[30];

            Random randNum = new Random();
            for (int i = 0; i < ArrayIntegers.Length; i++)
            {
                ArrayIntegers[i] = randNum.Next(Min, Max);
            }
            Console.WriteLine("Исходный массив выглядит следующим образом: ");
            printArray(ArrayIntegers);

            //Коппия исходного массива
            int[] ArrayIntegersCopy = (int[])ArrayIntegers.Clone();



            Console.WriteLine("***************LINQ запрос**************");
            int filteredArray = (
                from item in ArrayIntegers
                where item > 0
                where item % 2 == 0
                select item
            ).Min();
            Console.WriteLine($"Наименьшее значение среди четных чисел, MinEvenInteger = {filteredArray}.");
            Console.WriteLine("");



            Console.WriteLine("**********LINQ лямбда-выражение**********");
            int minEvenIntegerCopy = ArrayIntegersCopy.Where(item => item > 0).Where(item => item % 2 == 0).ToArray().Min();
            Console.WriteLine($"Наименьшее значение среди четных чисел, MinEvenInteger = {minEvenIntegerCopy}.");
        }
    }
}
