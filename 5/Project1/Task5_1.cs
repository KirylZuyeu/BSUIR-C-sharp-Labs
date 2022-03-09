using System;
using System.Collections.Generic;
using static System.Console;

/*
 * Лабораторная работа 5. ООП. Отношения классов. Ассоциации. 
 * Задание
 * Вариант 6
 * 1. Город – Достопримечательность – Турист – Гид. 
 */

namespace Project1
{
    class Task5_1
    {
        static string[] namesOfSights = new string[] { "Hagia Sophia Mosque", "Histiric Areas of Istanbul", "Halaskas tower", "Eyup Saltan Mosque", "Kiz Kulesi" };
        static string[] locationsOfSights = new string[] { "Sultanahme", "Sirkeci", "Beioglu", "Golden Horn", "Uskudar" };
        static string[] namesOfTourists = new string[] { "Kiryl", "Roman", "Dima", "Artem", "Anna" };
        static string[] nationalityOfTourists = new string[] { "Belarus", "Belarus", "Belarus", "Ukranian", "Ukranian" };
        static void Main(string[] args)
        {
            WriteLine($"Сreating an instance of a class without variables.");
            Excursion myTest1 = new Excursion();
            WriteLine($"{myTest1.ToString()}");
            WriteLine($"**************************************************");

            //Create Excursion
            Excursion myTurkey = new Excursion("myTurkey", "Turkey");

            //Sight completion
            myTurkey.City.sights = new Sight[5];
            for (int i = 0; i < myTurkey.City.sights.Length; i++)
            {
                myTurkey.City.sights[i] = new Sight(namesOfSights[i], locationsOfSights[i]);
            }

            //Group completion
            myTurkey.Tourists = new Tourist[5];
            for (int i = 0; i < myTurkey.Tourists.Length; i++)
            {
                myTurkey.Tourists[i] = new Tourist(namesOfTourists[i], nationalityOfTourists[i]);
            }

            //Join Guide
            myTurkey.Guide = new Guide("Ibrahim", "Turkish");

            WriteLine($"Results of methods for Instance class Excursion.");
            myTurkey.showInfoOfGuide();
            WriteLine($"------------------------------------------------");
            myTurkey.showListOfTourists();
            WriteLine($"------------------------------------------------");
            myTurkey.showListOfSights();
            WriteLine($"------------------------------------------------");
            myTurkey.changeGuide("Hasan", "Turkish");
            myTurkey.showInfoOfGuide();
            WriteLine($"------------------------------------------------");
            Sight newSight = new Sight("Beylerbeyi Palace", "Uskuadar");
            myTurkey.addSightForVisiting(newSight);
            myTurkey.showListOfSights();
            WriteLine($"************************************************");
        }
    }
}
