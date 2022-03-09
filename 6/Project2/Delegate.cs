using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    delegate void YaerOperationWithoutParams();
    public delegate void YaerOperationWithParams(int age, int value, Pet pet);
    //Анонимный делегат
    delegate void VoiceHandler(string voice);

    public delegate void SetNameParams(string name);

    public delegate void CalcNumberLegs(ref int x);


    //Лямбда-выражения
    public class Pet
    {

        public static string Name { get; set; }
        public int Age { get; set; }

        public static string Voice { get; set; }

        public static int Weight { get; set; }

        private YaerOperationWithoutParams setOlderOnOne;
        private YaerOperationWithParams setOlderOnMore;

        public SetNameParams setNameParams = (name) => {
            Name = name;
            Console.WriteLine($"Name was Changed on : {Name}");
        };


        public delegate void AccountHandler(string message);
        AccountHandler? notify;
        public event AccountHandler? Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"Method was Added");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"Method was Removed");
            }
        }

        public void SetOlderOn(int years)
        {
            Age += years;
            notify?.Invoke($"The pet will older on: {years} years.");
        }
        public void GetOlderOn(int limit)
        {
            if (Age >= limit)
            {
                notify?.Invoke($"The Pet is Older then {limit} years, and his Age: {Age}");
            }
            else
            {
                notify?.Invoke($"The Pet is NOT older then {limit} years, and his Age: {Age}"); ;
            }
        }

        public Pet(string name, int age, string voice, int weight)
        {
            Name = name;
            Age = age;
            Voice = voice;
            Weight = weight;
        }
        public void increaseOneYear()
        {
            Age = Age + 1;
            Console.WriteLine("Age was Increased on One Year.");
        }

        public void RegistrDeligateWithoutParams()
        {
            setOlderOnOne = increaseOneYear;
        }

        public void startDelegateOnOne()
        {
            setOlderOnOne();
        }

        public void RegistrDeligateWithParams(YaerOperationWithParams methodToCall)
        {
            setOlderOnMore = methodToCall;
        }

        public void startDelegateOnMore(int age, int value, Pet pet)
        {
            setOlderOnMore(age, value, pet);
        }

        public void Print()
        {
            Console.WriteLine($"I am {Name}, and my Age is {Age}.");
        }

        internal VoiceHandler getVoice = delegate (string voice)
        {
            Console.WriteLine($"I said ... {voice}!");
        };


    }
}
