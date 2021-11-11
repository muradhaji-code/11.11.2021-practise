using ExtensionMethods;
using System;
using System.Collections.Generic;


delegate void PrinterDelegate(int num);

namespace _11._11._2021_practise
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //Console.Write("Enter your text: ");
            //string text = Console.ReadLine();
            //foreach (var item in text.getWordList())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Task 2
            //Fruit[] basket = new Fruit[3];
            //Apple apple = new Apple
            //{
            //    VitaminValue = 10.2,
            //};
            //Orange orange = new Orange
            //{
            //    VitaminValue = 7.5,
            //};
            //PineApple pineApple = new PineApple
            //{
            //    VitaminValue = 15,
            //};
            //basket[0] = apple;
            //basket[1] = orange;
            //basket[2] = pineApple;
            //foreach (var item in basket)
            //{
            //    Console.WriteLine(item.VitaminValue);
            //}
            #endregion

            #region Task 3
            //List<KeyValuePair<string, int>> languagesList = new List<KeyValuePair<string, int>>();
            //languagesList.Add(new KeyValuePair<string, int>("C#", 2000));
            //languagesList.Add(new KeyValuePair<string, int>("Python", 1991));
            //languagesList.Add(new KeyValuePair<string, int>("Java", 1995));
            //languagesList.Add(new KeyValuePair<string, int>("PHP", 1994));
            //languagesList.Add(new KeyValuePair<string, int>("Go", 2009));
            //languagesList.Sort((a, b) => a.Key.CompareTo(b.Key));
            //foreach (var item in languagesList)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            //languagesList.Sort((a, b) => a.Value.CompareTo(b.Value));
            //Console.WriteLine("------------------------------");
            //foreach (var item in languagesList)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            #endregion

            #region Task 4
            PrinterDelegate printerDelegate = new PrinterDelegate(isNegative);
            printerDelegate += isPrime;
            printerDelegate += OddOrEven;
            printerDelegate(79);
            #endregion
        }

        public static void isNegative(int num)
        {
            Console.WriteLine($"{num} is {(num < 0 ? "Negative" : "Positive")}");
        }

        public static void isPrime(int num)
        {
            if (num < 2)
            {
                Console.WriteLine($"{num} is not Prime");
                return;
            };
            if (num < 4)
            {
                Console.WriteLine($"{num} is Prime");
                return;
            }
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine($"{num} is not Prime");
                return;
            }
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    Console.WriteLine($"{num} is not Prime");
                    return;
                }
            }
            Console.WriteLine($"{num} is Prime");
        }

        public static void OddOrEven(int num)
        {
            Console.WriteLine($"{num} is {(num % 2 == 1 ? "Odd" : "Even")}");
        }
    }

    abstract class Fruit
    {
        public abstract double VitaminValue { get; set; }
    }

    class Apple : Fruit
    {
        public override double VitaminValue { get; set; }
    }

    class Orange : Fruit
    {
        public override double VitaminValue { get; set; }
    }

    class PineApple : Fruit
    {
        public override double VitaminValue { get; set; }
    }
}