using System;
using System.Collections.Generic;

namespace Lesson7Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Malzahar = new Wizard("Malzahar", new List<string>() { "spell1", "spell2" }, Weapon.Bazooka, 23, 12);

            Console.WriteLine(Malzahar.Name);

        }
    }
}
