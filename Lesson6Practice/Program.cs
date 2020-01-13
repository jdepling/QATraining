using System;
using System.Collections.Generic;

namespace Lesson6Practice
{
    /// <summary>
    /// Practice with lists, dictionaries, and methods that the class did during the lesson
    /// </summary>
    class Program
    {
        
        public static void Speak(string message)
        {
            Console.WriteLine(message);
        }

        public static void AddThings(int num1, int num2)
        {
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        }
        
        static void Main(string[] args)
        {
            // list of Ints
            List<int> NickFavoriteNumbersYo = new List<int>();
            NickFavoriteNumbersYo.Add(1);
            NickFavoriteNumbersYo.Add(2);
            NickFavoriteNumbersYo.Add(3);
            NickFavoriteNumbersYo.Remove(3);

            // Looping through list
            foreach (int number in NickFavoriteNumbersYo)
            {
                Console.WriteLine(number);
            }

            for(var i = 0; i < NickFavoriteNumbersYo.Count; i++)
            {
                Console.WriteLine(NickFavoriteNumbersYo[i]);
            }

            NickFavoriteNumbersYo.ForEach(x => Console.WriteLine(x));

            // Dictionary key = string and value = string
            Dictionary<string, string> StringValueDictionary = new Dictionary<string, string>()
            {
                { "Chris", "Teriyaki" }
            };

            StringValueDictionary.Add("Adrianne", "Sweeto Burrito");
            StringValueDictionary["Justin"] = "Cheese Burgers";

            Console.WriteLine($"Chris: {StringValueDictionary["Chris"]}");
            Console.WriteLine($"Adrianne: {StringValueDictionary["Adrianne"]}");
            Console.WriteLine($"Justin: {StringValueDictionary["Justin"]}");


            Speak("Hi everyone!");

            AddThings(2, 5);

        }
    }
}
