using System;
using System.Collections.Generic;
using System.Linq;


/*
 * 8.5. LINQ с коллекцией
 * Создайте коллекцию объектов класса Person. 
 * Используемые поля – имя, год рождения, должность, оклад, компания (Company). 
 * Класс Company содержит название компании и год основания. Получите новую коллекцию, согласно варианту.
 * Вариант - 6)	Список лет, в которых были основаны компании. Содержит год и к-во компаний.
*/

namespace Project5
{
    public class Company
    {
        public string Name { get; set; }
        public int OriginYear { get; set; }

        public Company(string name, int originYear)
        {
            Name = name;
            OriginYear = originYear;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int BornYear { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public Company Company { get; set; }
        public Person(string name, int bornYear, string position, int salary, Company company)
        {
            Name = name;
            BornYear = bornYear;
            Position = position;
            Salary = salary;
            Company = company;
        }
    }
    class Task8_5
    {
        static void Main(string[] args)
        {
            Company jenty = new Company("Jenty", 1980);
            Company kapital = new Company("Kapital", 1985);
            Company primum = new Company("Primum", 1987);
            Company alience = new Company("Primum", 1980);
            Company rgroup = new Company("Rgroup", 1980);
            Company shelter = new Company("Shelter", 1985);
            Company shreder = new Company("Shreder", 1981);

            List<Person> collectiopnOfPersons = new List<Person>();
            collectiopnOfPersons.Add(new Person("Markus", 1994, "Manager", 35, jenty));
            collectiopnOfPersons.Add(new Person("Rien", 1982, "Lider", 45, kapital));
            collectiopnOfPersons.Add(new Person("Bob", 1992, "Manager", 33, primum));
            collectiopnOfPersons.Add(new Person("Jac", 1967, "Clerk", 28, alience));
            collectiopnOfPersons.Add(new Person("Helena", 1987, "Manager", 3, rgroup));
            collectiopnOfPersons.Add(new Person("Carlos", 1999, "Cleaner", 3, shelter));
            collectiopnOfPersons.Add(new Person("Pablo", 2000, "Manager", 3, shreder));

            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < collectiopnOfPersons.Count; i++)
            {
                if (!result.Keys.Contains(collectiopnOfPersons[i].Company.OriginYear))
                {
                    result.Add(collectiopnOfPersons[i].Company.OriginYear, 1);
                }
                else
                {
                    result[collectiopnOfPersons[i].Company.OriginYear]++;
                }
            }

            foreach (KeyValuePair<int, int> keyValue in result)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }
    }
}
