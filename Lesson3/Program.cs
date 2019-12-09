using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Greeting(name);

        }

        public static void Greeting(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
    }
}
