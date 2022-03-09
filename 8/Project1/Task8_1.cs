using System;
using System.Collections;
using System.Collections.Generic;

/*
 * Лабораторная работа 8. ООП. Обобщения и коллекции
 * Использование коллекции ArrayList.
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

    public class Bird : Animal, ICloneable, IComparable<Bird>, IFlying
    {
        public string name;
        public string habitat;
        public int weight;
        public int age;
        public int wings;

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

        public int Wings
        {
            get { return age; }
            set { age = value; }
        }


        public Bird(string name, string habitat) : this(name, habitat, 0, 0, 0)
        {
        }

        public Bird(string name, string habitat, int weight, int age, int wings)
        {
            this.name = name;
            this.habitat = habitat;
            this.weight = weight;
            this.age = age;
            this.wings = wings;
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

        public void Fly()
        {
            Console.WriteLine($"As I am {Name}, I can FLY.");
        }

        void IFlying.Up()
        {
            Console.WriteLine($"I deside, that for instances of {Name} don't needed will doing name in UpperCase.");
        }

        public void UpperCaseEagle()
        {
            ((IFlying)this).Up();
        }

        public static bool operator ==(Bird bird, string key)
        {
            return bird.Name == key;
        }

        public static bool operator !=(Bird bird, string key)
        {
            return bird.Name != key;
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
    class CompName<T> : IComparer<T>
    where T : Bird
    {
        public int Compare(T x, T y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }



    class Eagle : Bird, IFlying
    {
        public Eagle(string name, string habitat) : base(name, habitat)
        {
        }
        public Eagle(string name, string habitat, int weight, int age, int wings) : base(name, habitat, weight, age, wings)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"I am {Name} and i not often running, because i can Fly");
        }
        public new void Print()
        {
            Console.WriteLine($"I am a {Name} and I have {Wings} wings, my habitat is {Habitat}.");
        }
    }

    public class ComparerByName : IComparer
    {
        int IComparer.Compare(Object xx, Object yy)
        {
            Bird x = (Bird)xx;
            Bird y = (Bird)yy;
            //sort by age
            return x.Name.CompareTo(y.Name);
        }
    }
    class Task8_1
    {
        static void Main(string[] args)
        {
            Bird[] birdsCollection = new Bird[6] { new Eagle("White-Eagle", "Forest"), new Bird("Duck", "River"), new Bird("Penguine", "Ocean"), new Bird("Gull", "Sea"), new Eagle("Black-Eagle", "Canouone"), new Eagle("White-Eagle", "Forest") };
            ArrayList birdArrayList = new ArrayList();
            birdArrayList.AddRange(birdsCollection);

            Console.WriteLine("******Пункты консольного меню*****");
            Console.WriteLine("1 – просмотр коллекции");
            Console.WriteLine("2 – добавление элемента");
            Console.WriteLine("3 – добавление элемента по указанному индексу");
            Console.WriteLine("4 – нахождение элемента с начала коллекции");
            Console.WriteLine("5 – нахождение элемента с конца коллекции");
            Console.WriteLine("6 – удаление элемента по индексу");
            Console.WriteLine("7 – удаление элемента по значению");
            Console.WriteLine("8 – реверс коллекции");
            Console.WriteLine("9 – сортировка");
            Console.WriteLine("10 – выполнение методов всех объектов, поддерживающих Interface");
            Console.WriteLine("0 – выход");

            while (true)
            {
                Console.WriteLine("");
                Console.Write("Введите пункт меню: ");
                string key = Console.ReadLine();
                if (key == "0")
                {
                    break;
                }

                switch (key)
                {
                    case "1":
                        foreach (Bird emp in birdArrayList)
                        {
                            emp.Print();
                        }
                        break;
                    case "2":
                        Console.Write("Введите имя птицы: ");
                        string nameAdd = Console.ReadLine();
                        Console.Write("Введите среду обитания птицы: ");
                        string habitatAdd = Console.ReadLine();
                        birdArrayList.Add(new Bird(nameAdd, habitatAdd));
                        break;
                    case "3":
                        Console.Write("Введите индекс: ");
                        int addIndex = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите имя птицы: ");
                        string nameAddByIndex = Console.ReadLine();
                        Console.Write("Введите среду обитания птицы: ");
                        string habitatAddByIndex = Console.ReadLine();
                        birdArrayList.Insert(addIndex, new Bird(nameAddByIndex, habitatAddByIndex));
                        break;
                    case "4":
                        Console.Write("Введите Name элемента, (в качестве примера 'White-Eagle'): ");
                        string firstName = Console.ReadLine();
                        foreach (Bird emp in birdArrayList)
                        {
                            if (emp == firstName)
                            {
                                Console.WriteLine($"Элемент с именем: {firstName} был найден по {birdArrayList.IndexOf(emp)} индексу ArrayList.");
                                break;
                            } else
                            {
                                Console.WriteLine($"Элемент с именем: {firstName} не был найден в ArrayList.");
                            }
                        }
                        break;
                    case "5":
                        Console.Write("Введите Name элемента, (в качестве примера 'White-Eagle'): ");
                        string lastName = Console.ReadLine();
                        foreach (Bird emp in birdArrayList)
                        {
                            if (emp == lastName)
                            {
                                Console.WriteLine($"Элемент с именем: {lastName} был найден по {birdArrayList.Count - birdArrayList.LastIndexOf(emp)} индексу ArrayList.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Элемент с именем: {lastName} не был найден в ArrayList.");
                            }
                        }
                        break;
                    case "6":
                        Console.Write($"Введите Индекс удаляемого элемента (который не превышает {birdArrayList.Count}), IndexByDelete: ");
                        int deleteByIndex = Convert.ToInt32(Console.ReadLine());
                        birdArrayList.RemoveAt(deleteByIndex);
                        Console.WriteLine($"Элемент по индексу {deleteByIndex}, был успешно удален.");
                        break;
                    case "7":
                        Console.Write($"Введите имя элемента, который необходимо удалить, NameByDelete: ");
                        string deleteByName = Console.ReadLine();
                        foreach (Bird emp in birdArrayList)
                        {
                            if (emp == deleteByName)
                            {
                                birdArrayList.Remove(emp);
                                Console.WriteLine($"Операция удаления, была успешно проведена.");
                            }
                            else
                            {
                                Console.WriteLine($"Элемент с именем: {deleteByName} не был найден в ArrayList.");
                            }
                        }
                        break;
                    case "8":
                        birdArrayList.Reverse();
                        Console.WriteLine($"Реверс ArrayList был успешно произведен.");
                        break;
                    case "9":
                        birdArrayList.Sort(new ComparerByName());
                        Console.WriteLine($"Сортировка была успешно проведена по полю: Name.");
                        break;
                    case "10":
                        Console.WriteLine($"В качестве примера был использован метот UpperCaseEagle,\nкоторый показывает что Все элементы коллекции могут использовать методы Intarface2(IFlying).");
                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                        foreach (Bird emp in birdArrayList)
                        {
                            emp.UpperCaseEagle();
                        }
                        Console.WriteLine("----------------------------------------------------------------------------------------------");
                        break;
                    default:
                        Console.WriteLine($"Вы ввели некоректное значение пункта меню, повторите это действие еще раз.");
                        return;
                }
            }


        }
    }
}
