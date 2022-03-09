using System;

/*
 * Лабораторная работа 4. Перегрузка операций
 * Задание
 * Спроектировать класс согласно варианту индивидуального задания. Для класса использовать отдельный модуль.
 * Спроектировать конструкторы и свойства с контролем корректности вводимых значений.
 * перегрузить метод ToString()
 * добавить индексирование для получения полей класса
 * Перегрузить операции:
 * a)	математические (имеющие смысл для объектов класса)
 * b)	инкремент и декремент (изменить поля на 1)
 * c)	отношения (==, !=, <, >)
 * d)	true и false
 * e)	преобразования типа
 * В методе main()
 * - Создать несколько объектов класса. Продемонстрировать использование конструкторов и свойств.
 * - Продемонстрировать работу всех методов и операций.
 * Вариант 6
 * Класс vector
 */

namespace Project1
{
    class Task4_1
    {
        static void Main()
        {
            Vector vector1 = new Vector(1, 1, 1);
            Console.WriteLine($"<Vector1>: {vector1}");

            vector1[0] = 1;
            vector1[1] = 2;
            vector1[2] = 3;

            try
            {
                Console.WriteLine($"Change values by index, vector1[0] = {vector1[0]}");
                Console.WriteLine($"Change values by index, vector1[1] = {vector1[1]}");
                Console.WriteLine($"Change values by index, vector1[2] = {vector1[2]}");
                Console.WriteLine($"<Vector1> after changes: {vector1}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Vector vector2 = new Vector(-1, -10, -20);
            Console.WriteLine($"Vector2: {vector2}");

            Console.WriteLine($"<Vector1> + <Vector2>: {vector1 + vector2}");
            Console.WriteLine($"<Vector1> - <Vector2>: {vector1 - vector2}");

            Vector vector3 = new Vector(10, 10, 10);
            Vector vector3PostInk = vector3++;
            Vector vector3PostDek = vector3--;
            Console.WriteLine($"Vector3: {vector3}");
            Console.WriteLine($"Inkrement <Vector3>++: {vector3PostInk}");
            Console.WriteLine($"Decrement <Vector3>--: {vector3PostDek}");

            Vector vector4 = new Vector(10, 10, 10);
            Vector vector5 = new Vector(9, 9, 9);
            Console.WriteLine($"Multiplication <Vector4> * <Vector5>: {vector4} * {vector5} = {vector4 * vector5} ");
 
            Vector vector6 = new Vector(10, 10, 10);
            int multiplier = 2;
            int divider = 2;
            Console.WriteLine($"Vector6: {vector6}");
            Console.WriteLine($"Multiplication <Vector6> * {multiplier}: {vector6 * multiplier}");
            Console.WriteLine($"Division <Vector6> / {divider}: {vector6 / divider}");

            Console.WriteLine($"<Vector4> == <Vector5>: {vector4} == {vector5} => {vector4 == vector5} ");
            Console.WriteLine($"<Vector4> != <Vector5>: {vector4} != {vector5} => {vector4 != vector5} ");

            Console.WriteLine($"<Vector4> < <Vector5>: {vector4} < {vector5} => {vector4 < vector5} ");
            Console.WriteLine($"<Vector4> > <Vector5>: {vector4} > {vector5} => {vector4 > vector5} ");



            if (vector6)
            {
                Console.WriteLine($"<Vector6>: {vector6} == true");
            }
            else {
                Console.WriteLine($"<Vector6>: {vector6} == false");
            }

            Vector vector7 = new Vector(0, 0, 0);

            if (vector7)
            {
                Console.WriteLine($"<Vector7>: {vector7} == true");
            }
            else
            {
                Console.WriteLine($"<Vector7>: {vector7} == false");
            }

            Console.WriteLine($"Explicit conversion <Vector6>: {vector6}, to type double: <Vector6> => {(double)vector6}");
            int number = 10;
            Console.WriteLine($"Explicit conversion Integer: {number}, to <Vector>: Integer => {(Vector)number}");

            Console.ReadKey();
        }
    }
}
