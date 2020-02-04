using System;

namespace Lesson8
{
    public class Dice
    {
        public static void Roll()
        {
            Console.WriteLine("You rolled a {0}", new Random().Next(0, 20));
        }
    }
}
