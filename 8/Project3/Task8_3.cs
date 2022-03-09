using System;
using System.Collections;
using System.Collections.Generic;

/*
 * 8.3. Обобщенный метод
 * Создайте обобщенный метод, который получает массив произвольного типа и возвращает количество элементов, не равных null.
*/

namespace Project3
{
    public static class CollectionExtensions
    {
        public static int GetCount<T>(this ICollection<T> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Count;
        }

        public static int GetCount(this ICollection source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Count;
        }
    }

    class Program
    {
        public static int getLength(object[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    ++count;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            object[] arrByObject = { true, 10, "Привет", 13.7m, null, null };
            Console.WriteLine($"Длинна массива искулючая значения null, Lenght = {getLength(arrByObject)}");
        }
    }
}
