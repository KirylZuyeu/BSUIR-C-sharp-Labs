using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Лабораторная работа 3. Разработка классов
 * Вариант 6
 * Класс «Грузоперевозки». 
 * В вашем классе
 * Предусмотреть у класса наличие полей, методов и свойств. Названия членов класса должны быть осмысленны. 
 * Для всех нетекстовых полей разработать свойства, контролирующие корректность значения (например, оценка – от 0 до 10). 
 * Одно из свойств (имя объекта) должно быть только для чтения с инициализацией в конструкторе. Поля, связанные со свойствами, должны быть инкапсулированы.
 * Разработать несколько конструкторов класса (не менее 3). Один – без аргументов, с заполнением полей значением по умолчанию, 
 * второй – с полным набором аргументов и третий с частичным набором аргументов. 
 * Связать конструкторы в цепочку, дабы избежать дублирования кода. Для проверки корректности аргументов в конструкторах использовать свойство. 
 * Переопределить метод ToString()для отображения всех полей класса. 
 * Разработать указанные для вашего варианты методы.
 * Создать автоматическую диаграмму спроектированного класса.
 * Класс «Грузоперевозки». 
 * Поля:
 * название фирмы,
 * грузоподъемность фур (массив),
 * стоимость перевозки 1 тонны,
 * суммарная масса перевозимых грузов
 * Методы:
 * ToString(),
 * метод для определения процентной выручки от максимально возможной (суммарную грузоподъемность умножить на стоимость перевозки 1 тонны)
 * метод, определяющий, падение рентабельности (если масса реально перевезенных грузов меньше максимальной более чем на 40%, стоимость падает на 15%)
 * метод, определяющий более рентабельную фирму из двух – по проценту рентабельности (возвращает true, если текущая более рентабельна)
 * статический метод, определяющий более рентабельную фирму из трех (возвращает объект, чья рентабельность выше)
 */

namespace Project1
{
    public class Trucking
    {
        public string СompanyName { get; }
        private double transportationPrice;
        private double nominalWeightOfCargos;
        private double realWeightOfCargos;
        private double[] truckLoadCapacity = new double[4];

        public double TransportationPrice
        {
            get
            {
                return transportationPrice;
            }

            set
            {
                if (transportationPrice < 0)
                {
                    Console.WriteLine("Price can't be less then 0 !!!");
                }
                else
                {
                    transportationPrice = value;
                }
            }
        }

        public double NominalWeightOfCargos
        {
            get
            {
                return nominalWeightOfCargos;
            }

            set
            {
                if (nominalWeightOfCargos < 0)
                {
                    Console.WriteLine("Nominal Weight Of Cargos can't be less then 0 !!!");
                }
                else
                {
                    nominalWeightOfCargos = value;
                }
            }
        }

        public double RealWeightOfCargos
        {
            get
            {
                return realWeightOfCargos;
            }

            set
            {
                if (realWeightOfCargos < 0)
                {
                    Console.WriteLine("Real Weight Of Cargos can't be less then 0 !!!");
                }
                else
                {
                    realWeightOfCargos = value;
                }
            }
        }

        public double[] TruckLoadCapacity
        {
            get
            {
                return truckLoadCapacity;
            }
            set
            {

                if (truckLoadCapacity.Length < 0)
                {
                    Console.WriteLine("If company doesn't have truck Load Capacity, they can't carry!!! Change this value");
                }
                else
                {
                    truckLoadCapacity = value;
                }

            }
        }


        public Trucking() : this("Name missing", 0, 0, 0, 0, 0, 0)
        {
        }

        public Trucking(string companyName) : this(companyName, 0, 0, 0, 0, 0, 0)
        {
        }

        public Trucking(string companyName, double transportationPrice, double nominalWeightOfCargos, double realWeightOfCargos, params double[] truckLoadCapacity)
        {
            СompanyName = companyName;
            TransportationPrice = transportationPrice;
            NominalWeightOfCargos = nominalWeightOfCargos;
            RealWeightOfCargos = realWeightOfCargos;
            TruckLoadCapacity = truckLoadCapacity;
        }

        public string printArray(double[] array)
        {
            return $"[{string.Join(", ", array)}]";
        }

        public double getPercentageRevenue()
        {
            double sum = 0;

            for (int i = 0; i < TruckLoadCapacity.Length; i++)
            {
                sum += TruckLoadCapacity[i];
            }

            return sum * TransportationPrice;
        }

        public bool isDropInProfitability(double percent)
        {
            return RealWeightOfCargos < (NominalWeightOfCargos * percent) / 100;
        }

        public bool isMoreProfitability(Trucking truckingCompany)
        {
            return (RealWeightOfCargos / NominalWeightOfCargos) > (truckingCompany.RealWeightOfCargos / truckingCompany.NominalWeightOfCargos);
        }

        public static Trucking TheMostCostEffective(List<Trucking> truckingList)
        {
            return truckingList.OrderByDescending(item => item.RealWeightOfCargos / item.NominalWeightOfCargos).First();
        }

        public override string ToString()
        {
            return $"Сompany Name: {СompanyName}\n" +
                   $"Transportation Price: {TransportationPrice}\n" +
                   $"Nominal Weight Of Cargos: {NominalWeightOfCargos}\n" +
                   $"Real Weight Of Cargos: {RealWeightOfCargos}\n" +
                   $"Truck Load Capacity: {printArray(TruckLoadCapacity)}";
        }
    }
}
