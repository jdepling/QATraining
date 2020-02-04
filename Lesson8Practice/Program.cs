using System;

namespace Lesson8Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Dragon Smaug = new Dragon(25, 3000, "Smaug");
            Console.WriteLine(Smaug.AC);
            Console.WriteLine(Smaug.HP);
            Console.WriteLine(Smaug.Name);

            Smaug.Attack();

            Monster dumbMonster = new Monster();

           

        }
    }
}
