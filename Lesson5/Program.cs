using System;
using System.Collections.Generic;

namespace Lesson5
{
    /// <summary>
    /// Arrays
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an Array
            string[] someArray;

            // Declare and Initialize an array at once
            string[] myFavoriteFoods = new string[4]; // This means this array can have 4 spots in it or 4 indices. 
                                                      // Indices are plural for index. 0,1,2,3 are our 4 indexes/indices
                                                      // You only do this when you know how big you want your array a head of time

            // Assign values to an array ... a really stupid way ... but it shows us about indexes/indices
            myFavoriteFoods[0] = "burgers";         // Index 0
            myFavoriteFoods[1] = "pizza";          // Index 1
            myFavoriteFoods[2] = "chicken wings"; // Index 2
            myFavoriteFoods[3] = "gyros";        // Index 3

            // Declare and initialize an array all at once ... when you know your exact values a head of time
            string[] nicksFavoriteFoods = { "chicken wings", "donut chicken sandwiches", "pizza" };

            // Access an element in an array (This means grabbing one of these stored values)
            string nickFood = nicksFavoriteFoods[1];
            Console.WriteLine(nickFood);

            // Altering an element in an array
            nicksFavoriteFoods[2] = "gyros";
            Console.WriteLine(nicksFavoriteFoods[2]);

            // Iterating over the array. This means looping through an array. 
            // What this really means is we are going to go through all the values in the array and look at them
            for (int i = 0; i < nicksFavoriteFoods.Length; i++) // => nicksFavoriteFoods.Length = 3
            {
                Console.WriteLine(nicksFavoriteFoods[i]);
            }

            // An easier way to loop through an array
            foreach (string food in nicksFavoriteFoods)
            {
                Console.WriteLine(food);
            }

            // Example with numbers
            int[] numbers = { 10, 20, 30, 40 };
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            // What foods do Nick and I have in common?
            string[] foodsWeBothLike = FoodsInCommon(myFavoriteFoods, nicksFavoriteFoods);
            Console.WriteLine("These are the foods that both Nick and I like...");

            foreach (string food in foodsWeBothLike)
            {
                Console.WriteLine(food);
            }

            // Lists
            List<string> ChrisFavoriteFoods = new List<string>();
            ChrisFavoriteFoods.Add("teriyaki");
            ChrisFavoriteFoods.Add("steak");
            ChrisFavoriteFoods.Add("fajitas");
            ChrisFavoriteFoods.Add("tacos");
            ChrisFavoriteFoods.Remove("tacos");

            Console.WriteLine("Chris's favorite foods");
            foreach (string foodItem in ChrisFavoriteFoods)
            {
                Console.WriteLine(foodItem);
            }
        }

        /// <summary>
        /// This will return the foods that both Nick and I like
        /// </summary>
        public static string[] FoodsInCommon(string[] person1FavoriteFood, string[] person2FavoriteFood)
        {
            string[] foodsInCommon = new string[10]; // Array that will hold the foods we have in common
            int i = 0; // This will control which index will be written to

            // Loop through person one's favorite foods
            foreach(string person1Food in person1FavoriteFood)
            {
                // Loop through person two's favorite foods
                foreach(string person2Food in person2FavoriteFood)
                {
                    // See if we find a match
                    if(person1Food == person2Food)
                    {
                        // A match has been found. Let's store it in our new array
                        foodsInCommon[i] = person1Food;
                        i++; // Increment i. This ensures that we will write the next "food in common" into the next available index of our array.
                    }
                }
            }

            return foodsInCommon;
        }
    }
}
