using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Лабораторная работа 7. Интерфейсы
 */

namespace Project1
{
    interface IFlying
    {
        int Wings { get; set; }
        public void Fly();

        public void Up();

    }

    interface ICloneable
    {
        object Clone();
    }

    interface Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        public void Print();
        public void SetOlder();
        public void GetOlder();
        public void AnimalSound();
        public void Move();
        public void Up();
    }


    class Dog : Animal
    {
        private string name;
        private string habitat;
        private int weight;
        private int age;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Dog(string name, string habitat, int weight, int age)
        {
            this.name = name;
            this.habitat = habitat;
            this.weight = weight;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"I am a {Name} and my habitat is {Habitat}.");
        }

        public void SetOlder()
        {
            this.age = this.age + 1;
            Console.WriteLine($"I am {Name} and i am 1 year older.");
        }

        public void GetOlder()
        {
            Console.WriteLine($"I am {Name} and my age is {Age}.");
        }

        public void AnimalSound()
        {
            Console.WriteLine($"I am {Name} and my voice is Gaf Gaf.");
        }

        public void Move()
        {
            Console.WriteLine($"I am {Name} I prefer running.");
        }
        void Animal.Up()
        {
            this.name = name.ToUpper();
            Console.WriteLine($"Name for in UpperCase: {Name}.");
        }
    }

    public class Bird : Animal, ICloneable, IComparable<Bird>
    {
        public string name;
        public string habitat;
        public int weight;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Bird(string name, string habitat) : this(name, habitat, 0, 0)
        {
        }

        public Bird(string name, string habitat, int weight, int age)
        {
            this.name = name;
            this.habitat = habitat;
            this.weight = weight;
            this.age = age;
        }
        public void Print()
        {
            Console.WriteLine($"I am a {Name} and my habitat is {Habitat}.");
        }

        public void SetOlder()
        {
            this.age = this.age + 1;
            Console.WriteLine($"I am {Name} and i am 1 year older.");
        }

        public void GetOlder()
        {
            Console.WriteLine($"I am {Name} and my age is {Age}.");
        }

        public void AnimalSound()
        {
            Console.WriteLine($"I am {Name} and my voice is Chik Chik.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"I am {Name} I don't prefer running.");
        }

        void Animal.Up()
        {
            this.name = name.ToUpper();
            Console.WriteLine($"Name for in UpperCase: {Name}.");
        }

        public object Clone()
        {
            return new Bird(this.name, this.habitat);
        }

        public int CompareTo(Bird obj)
        {
            return name.CompareTo(obj.name);

        }
    }

    class CompAge<T> : IComparer<T>
        where T : Bird
    {
        public int Compare(T x, T y)
        {
            if (x.Age < y.Age)
                return 1;
            if (x.Age > y.Age)
                return -1;
            else return 0;
        }
    }

    class CompWeight<T> : IComparer<T>
    where T : Bird
    {
        public int Compare(T x, T y)
        {
            if (x.Weight < y.Weight)
                return 1;
            if (x.Weight > y.Weight)
                return -1;
            else return 0;
        }
    }


    class Eagle : Bird, IFlying
    {
        public int wings;
        public int Wings
        {
            get { return wings; }
            set { wings = value; }
        }

        public Eagle(string name, string habitat) : base(name, habitat)
        {
        }
        public Eagle(string name, string habitat, int weight, int age, int wings) : base(name, habitat, weight, age)
        {
            this.wings = wings;
        }

        public void Fly()
        {
            Console.WriteLine($"As I am {Name}, I can FLY.");
        }
        public override void Move()
        {
            Console.WriteLine($"I am {Name} and i not often running, because i can Fly");
        }
        public new void Print()
        {
            Console.WriteLine($"I am a {Name} and I have {Wings} wings, my habitat is {Habitat}.");
        }

        void IFlying.Up()
        {
            Console.WriteLine($"I deside, that for instances of {Name} don't needed will doing name in UpperCase.");
        }

        public void UpperCaseEagle()
        {
            ((IFlying)this).Up();
        }

    }

    class Task7_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. The subject area is taken from laboratory work number 6 - Animal - Dog and Bird(Eagle)");
            Console.WriteLine("");
            Console.WriteLine("***********************DOG***********************");
            Dog dog = new Dog("Dog", "Eath", 10, 10);
            dog.Print();
            dog.GetOlder();
            dog.SetOlder();
            dog.GetOlder();
            dog.AnimalSound();
            dog.Move();
            if (dog is Animal) Console.WriteLine($"{dog.Name} support Intarfece of Animal");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");
            Console.WriteLine("***********************BIRD**********************");
            Bird bird = new Bird("Bird", "Air", 10, 10);
            bird.Print();
            bird.GetOlder();
            bird.SetOlder();
            bird.GetOlder();
            bird.AnimalSound();
            if (bird is Animal) Console.WriteLine($"{bird.Name} support Intarfece of Animal");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");
            Console.WriteLine("***********************EAGLE**********************");
            Eagle eagle = new Eagle("Eagle", "Air", 10, 10, 2);
            eagle.Print();
            eagle.GetOlder();
            eagle.SetOlder();
            eagle.GetOlder();
            eagle.AnimalSound();
            eagle.Fly();
            if (eagle is Animal) Console.WriteLine($"{eagle.Name} support Intarfece of Animal");
            if (eagle is IFlying) Console.WriteLine($"{eagle.Name} support Intarfece of IFlying");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");
            Console.WriteLine("***********************2. Collision**********************");
            Console.WriteLine("***********************Collision:gluing**********************");
            bird.Move();
            eagle.Move();
            Console.WriteLine("");
            Console.WriteLine("***********************Collision:casting**********************");
            ((IFlying)eagle).Up();
            Console.WriteLine("");
            Console.WriteLine("******************Collision:casting+wrapping******************");
            eagle.UpperCaseEagle();
            Console.WriteLine("");
            Console.WriteLine("**********************3. Array of Intarfaces*********************");

            Animal[] birds = new Animal[5] { new Eagle("White-Eagle", "Forest", 11, 2, 2), new Bird("Duck", "River", 7, 1), new Bird("Penguine", "Ocean", 8, 3), new Bird("Gull", "Sea", 7, 4), new Eagle("Black-Eagle", "Canouone", 10, 3, 2) };
            Console.WriteLine("**Instances of Bird Class that have IFlying Interface Methods**");
            foreach (Animal someBird in birds)
            {
                if (someBird is IFlying) {
                    Console.Write($"{someBird.Name}: ");
                    ((IFlying)someBird).Fly();
                }
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("************************4. Standar Intarfeces**********************");
            Console.WriteLine("******************Create Clone of birds*************************");
            List<Bird> birdArray = new List<Bird>();
            birdArray.Add(new Eagle("White-Eagle", "Forest", 11, 2, 2));
            birdArray.Add(new Bird("Duck", "River", 7, 1));
            birdArray.Add(new Bird("Penguine", "Ocean", 8, 3));
            birdArray.Add(new Bird("Gull", "Sea", 7, 4));
            birdArray.Add(new Eagle("Black-Eagle", "Canouone", 10, 3, 2));
            Console.WriteLine("******************Before Sotring by Name*************************");
            foreach (var emp in birdArray)
            {
                Console.WriteLine($"Name: {emp.Name}");
            }
            birdArray.Sort();
            Console.WriteLine("******************After Sotring by Name*************************");
            foreach (var emp in birdArray)
            {
                Console.WriteLine($"Name: {emp.Name}");
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("");
            Console.WriteLine("******************Comparer:Sotring descending by Age***********************");
            CompAge<Bird> cA = new CompAge<Bird>();
            birdArray.Sort(cA);
            foreach (Bird birdIstance in birdArray) {
                Console.WriteLine($"{birdIstance.Name} and his Age: {birdIstance.Age}");
            }
            Console.WriteLine("******************Comparer:Sotring descending by Weight***********************");
            CompWeight<Bird> cW = new CompWeight<Bird>();
            birdArray.Sort(cW);
            foreach (Bird birdIstance in birdArray)
            {
                Console.WriteLine($"{birdIstance.Name} and his Weight: {birdIstance.Weight}");
            }
            Console.WriteLine("");
        }
    }
}
