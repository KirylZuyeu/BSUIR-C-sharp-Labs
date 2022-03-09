using System;

/*
 * Лабораторная работа 6. ООП. Наследование. Делегаты, события
 * Задание 2. Делегаты, события. 
 * Вариант 6
 */

namespace Project2
{
    class Task6_2
    {
        static void increaseMoreYear(int age, int value, Pet pet)
        {
            pet.Age = age + value;
            Console.WriteLine("");
            Console.WriteLine("Age was Increased More then One Year.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("**********Delegates**********");
            Pet myPet = new Pet("Cat", 12, "voice", 4);
            // Инициализируем делегат
            myPet.RegistrDeligateWithoutParams();
            myPet.startDelegateOnOne();
            myPet.Print();
            // Делегаты с параметрами - взросление
            myPet.RegistrDeligateWithParams(increaseMoreYear);
            myPet.startDelegateOnMore(myPet.Age, 2, myPet);
            myPet.Print();
            // Проверка анонимных делегатов - разговор питомца
            myPet.getVoice("Miay, Miay");
            myPet.getVoice("Voff, Voff");
            // Проверка Лямбда-выражений
            myPet.setNameParams("Dog");
            myPet.Print();

            // События
            Console.WriteLine("**********Events**********");
            void DisplayMessage(string message) => Console.WriteLine(message);
            Console.Write("Check that ADD was working: ");
            myPet.Notify += DisplayMessage;   
            myPet.SetOlderOn(2);
            myPet.SetOlderOn(3);
            myPet.SetOlderOn(4);
            myPet.GetOlderOn(7);
            myPet.GetOlderOn(26);
            Console.Write("Check that REMOVE was working: ");
            myPet.Notify -= DisplayMessage;

            Console.ReadLine();
        }
    }
}
