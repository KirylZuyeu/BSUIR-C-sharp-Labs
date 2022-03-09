using System;

/*
 * Лабораторная работа 6. ООП. Наследование. Делегаты, события
 * Задание 1. Наследование
 */

namespace Project1
{
    class Task6_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Creation of Animal Class - he is abstaract.*********");
            //Animal animal = new Animal();
            Console.WriteLine("*****Pushing Error Of Compilation, because he is abstact*****");
            Console.WriteLine("");
            Console.WriteLine("************Creation the instances of Animal Class***********");
            Console.WriteLine("*************************Cat*********************************");
            Cat cat = new Cat("Cat", "Eath", 10, 2, 4);
            cat.GetLimbs();
            cat.Move();
            cat.Print();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");
            Console.WriteLine("*************************Dog*********************************");
            Dog dog = new Dog("Dog", "Eath", 12, 3, 4);
            dog.GetLimbs();
            dog.Move();
            dog.Print();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");
            Console.WriteLine("*************************Fish********************************");
            Fish fish = new Fish("Fish", "Water", 12, 5, 5);
            fish.GetLimbs();
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Virtual Method: ");
            fish.Move();
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Overload Method: ");
            fish.Print();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");
            Console.WriteLine("*************************Bird********************************");
            Bird bird = new Bird("Bird", "Air", 2, 1, 2);
            bird.GetLimbs();
            bird.Move();
            bird.Print();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");
            Console.WriteLine("***********************Inharitance***************************");
            Console.WriteLine("***********************Home Cat******************************");
            HomeCat homeCat = new HomeCat("HomeCat", "Eath", 8, 5, 4, "Barsik");
            homeCat.Print();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");
            Console.WriteLine("*************************Wolf********************************");
            Wolf wolf = new Wolf("Wolf", "Eath", 12, 3, 4, "Alpha");
            wolf.Print();
            Console.WriteLine("*************************************************************");
            Console.WriteLine("");
            Console.WriteLine("**************************Shark******************************");
            Shark shark = new Shark("Shark", "Ocean", 12, 3, 6, "Murder");;
            shark.Print();
            Console.WriteLine("*************************************************************");
        }
    }
}
