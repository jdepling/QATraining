using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson6
{
    /// <summary>
    /// More on data structures
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // List of strings that holds food items
            List<string> theFoods = new List<string>();
            theFoods.Add("Burger");
            theFoods.Add("Pizza");
            theFoods.Add("Wings");
            theFoods.Add("Gyro");
            theFoods.Add("Stir Fry");

            // Looping through a list
            Console.WriteLine("Using a foreach loop to loop through a list:");
            foreach(string food in theFoods)
            {
                Console.WriteLine(food);
            }
            Console.WriteLine("*******************************");

            // Looping through a List using the built in ForEach() method
            Console.WriteLine("Using the built in ForEach method on a List:");
            theFoods.ForEach((food) => Console.WriteLine(food));

            // Dictionaries
            // Declare and initialize a dictionary
            // This dictionary is nothing more than a key value pair
            // The key is a string and the value is a List<string> ... list of strings
            var FoodIndex = new Dictionary<string, List<string>>()
            { 
                { "Adrianne", new List<string> { "Pizza" } }
            };

            // Lets make it more simple by first making a list. And then we will add these lists to the dictionary...

            // Adrianne
            List<string> AdrianneFoods = new List<string> // Another way to make a list if you don't want to use the Add() method
            {
                "Pizza",
                "Sweeto Burrito",
                "Burgers",
                "Brownies"
            };
            // Because we have an entry already for Adrianne in our dictionary we need to over write it
            FoodIndex["Adrianne"] = AdrianneFoods;

            // Chris
            List<string> ChrisFoods = new List<string>();
            ChrisFoods.Add("Teriyaki");
            ChrisFoods.Add("Pizza");
            ChrisFoods.Add("Ice Cream");
            ChrisFoods.Add("Yogurt");

            // Nick
            List<string> NickFoods = new List<string>();
            ChrisFoods.Add("Wings");
            ChrisFoods.Add("Pizza");
            ChrisFoods.Add("Burgers");
            ChrisFoods.Add("Philly Cheese Steak");

            // Justin
            List<string> JustinFoods = new List<string>();
            ChrisFoods.Add("Burgers");
            ChrisFoods.Add("Wings");
            ChrisFoods.Add("Ribs");
            ChrisFoods.Add("Steak");

            // Make our dictionary a little easier by adding our lists instead of doing it all on one line and confusing everyone
            FoodIndex.Add("Chris",  ChrisFoods);
            FoodIndex.Add("Nick",   NickFoods);
            FoodIndex.Add("Justin", JustinFoods);

            Console.WriteLine("************************************************");
            Console.WriteLine("Let's see what Adrianne and Chris have in common:");
            List<string> AdrianneAndChris = FoodsInCommon(FoodIndex["Adrianne"], FoodIndex["Chris"]);
            AdrianneAndChris.ForEach((food) => Console.WriteLine(food));
        }

        /// <summary>
        /// - Takes 2 lists of foods
        /// - Compares the 2 lists for food items they have in common
        /// - Returns a list of matching food items
        /// </summary>
        public static List<string> FoodsInCommon(List<string> person1Foods, List<string> person2Foods)
        {
            // LINQ
            return person1Foods.Intersect(person2Foods).ToList(); // Do you remember how hard to read this method was in the last lesson?
            // Intersect returns an IEnumberable<string> so I need to call ToList() to make it a List<string>
        }
    }
}
