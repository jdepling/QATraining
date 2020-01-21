using System.Collections.Generic;

namespace Lesson7
{
    public class Person
    {
        // Properties other classes and files can access (public)
        public string Name { get; set; }
        public int    Age { get; set; }
        public Gender Gender { get; set; }
        public List<string> FavoriteFoods { get; set; }

        // Properties that other classes can't access
        private readonly string _secret;
        private readonly string _password;


        // A Constructor is the method you call to create your object.
        // It has the same name as your class name
        public Person(string name, int age, Gender gender)
        {
            /* To create a person we are going to pass in these variables and assign them
              to our properties above.
              Note that we don't need to pass in something for FavoriteFoods. 
              You can pick and choose which properties are required to have a person object
           */

            Name   = name;
            Age    = age;
            Gender = gender;

            // We are going to set our secret
            if (age < 30 && gender == Gender.Male)
            {
                _secret = "I am young";
            } else if(age >= 30 && gender == Gender.Male)
            {
                _secret = "I am old";
            }
            else
            {
                _secret = "A lady doesn't have secrets. A lady is just simply mysterious.";
            }

            _password = "password";
        }

        /// <summary>
        /// Returns a secret if you know the password
        /// </summary>
        public string GetSecret(string password)
        {
            if (password == _password)
                return _secret;

            return "You will never know my secret!";
        }
    }

    /// <summary>
    /// This is an enum ...
    /// You never know what someone is going to pass you if you use strings, for example
    /// A male may pass in "Male", "Man", "male", "M", "m", "Dude", ... it is impossible to be
    /// able to handle all of that.
    /// Using an enum keeps it all consistent. And it enforces it to a limited set of options.
    /// In this case: Female and Male.
    /// </summary>
    public enum Gender
    {
        Female,
        Male
    }
}
