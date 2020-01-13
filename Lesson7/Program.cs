using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Lesson7
{
    /// <summary>
    /// Intro to Object Oriented Programming
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create our people, by calling the constructor
            Person adrianne = new Person("Adrianne", 21, Gender.Female);
            Person chris    = new Person("Chris",    25, Gender.Male);
            Person nick     = new Person("Nick",     12, Gender.Male);
            Person matt     = new Person("Matt",     24, Gender.Male);
            Person justin   = new Person("Justin",   65, Gender.Male);

            // Access the variables (known as fields) in an object using the dot (.) syntax
            // How old is Justin?
            Console.WriteLine("Justin is {0} years old", justin.Age);

            // Our people need favorite foods -- We will use the "Public" property FavoriteFoods and set it
            adrianne.FavoriteFoods = new List<string>()
            {
                "Pizza",
                "Broccoli",
                "Spinach",
                "Apples",
                "Brownies"
            };

            /* Why can't I access the "private" _secret variable directly?
             * How is it that I could access the "public" FavoriteFoods property?
             */

             // I guess I have to use the Public GetSecret() method to access our private _secret
            Console.Write("Justin's secret: ");
            Console.WriteLine(justin.GetSecret("password"));
            Console.WriteLine("**************************");

            Console.Write("Adrianne's secret: ");
            Console.WriteLine(adrianne.GetSecret("password"));
        }
    }
}
