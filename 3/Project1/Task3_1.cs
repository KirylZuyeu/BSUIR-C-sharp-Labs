using System;
using System.Collections.Generic;
using System.Linq;

/*
 * Лабораторная работа 3. Разработка классов
 * Задание.
 * Спроектировать класс согласно варианту индивидуального задания. Для класса использовать отдельный модуль.
 * Требования для модуля где производится вход в приложение:
 * В методе main()
 * Создать несколько объектов класса. Продемонстрировать использование всех конструкторов.
 * Продемонстрировать работу всех методов.
 * Продемонстрировать использование всех свойств – для получения и присваивания значения.
 * Создать еще одну переменную, присвоив ей один из предыдущих объектов. 
 * Продемонстрировать, что две переменные ссылаются на один объект (поменять поле в одном объекте и вывести его в другом).
 * Вариант 6
 * Класс «Грузоперевозки». 
 */

namespace Project1
{
    class Task3_1
    {
        static double[] jentyCapacity = new double[] { 15, 20, 30, 40 };
        static double[] kapitalCapacity = new double[] { 18, 20, 24, 30 };
        static double[] primumCapacity = new double[] { 15, 18, 24, 40 };

        static double persontages = 40;
        static void Main()
        {
            Console.WriteLine("************Check All Constructors************");
            Trucking fullEmpty = new Trucking();
            Console.WriteLine(fullEmpty.ToString());
            Trucking onlyName = new Trucking("rGroup");
            Console.WriteLine(onlyName.ToString());
            Console.WriteLine("**********************************************");
            Console.WriteLine("");

            Trucking jenty = new Trucking("jenty", 1000, 10000, 3000, jentyCapacity);
            Trucking kapital = new Trucking("kapital", 900, 12000, 11000, kapitalCapacity);
            Trucking primum = new Trucking("primum", 1100, 16000, 15000, primumCapacity);

            Console.WriteLine("**********Displaying Class Instances**********");
            Console.WriteLine(jenty.ToString());
            Console.WriteLine(kapital.ToString());
            Console.WriteLine(primum.ToString());
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("*********Calculate Percentage Revenue*********");
            Console.WriteLine($"Percentage Revenue for Jenty {jenty.getPercentageRevenue()}");
            Console.WriteLine($"Percentage Revenue for Kapital {kapital.getPercentageRevenue()}");
            Console.WriteLine($"Percentage Revenue for Primum {primum.getPercentageRevenue()}");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("************Drop In Profitability************");
            Console.WriteLine($"Drop In Profitability more then {persontages}%: {jenty.isDropInProfitability(persontages)}");
            Console.WriteLine($"Drop In Profitability more then {persontages}%: {kapital.isDropInProfitability(persontages)}");
            Console.WriteLine($"Drop In Profitability more then {persontages}%: {primum.isDropInProfitability(persontages)}");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("***********More Profitability In Both**********");
            Console.WriteLine($"{jenty.СompanyName} More Profitability then {kapital.СompanyName} : {jenty.isMoreProfitability(kapital)}");
            Console.WriteLine($"{kapital.СompanyName} More Profitability then {primum.СompanyName}: {kapital.isMoreProfitability(primum)}");
            Console.WriteLine($"{primum.СompanyName} More Profitability then {jenty.СompanyName}: {primum.isMoreProfitability(jenty)}");
            Console.WriteLine("**********************************************");
            Console.WriteLine("");
            Console.WriteLine("***********Most Profitability In Third**********");
            List<Trucking> truckingList = new List<Trucking> { jenty, kapital, primum };
            Console.WriteLine($"The most profitability between third:\n{Trucking.TheMostCostEffective(truckingList).ToString()}");
            Console.WriteLine("**********************************************");
            Console.ReadKey();
        }
    }
}
