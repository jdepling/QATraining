using System;

namespace QATraining
{
    /// <summary>
    /// Class that changes based upon what I am teaching
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // out
            int quantityOfBurritos;
            GiveMeFood(out quantityOfBurritos);
            Console.WriteLine("How many burritos?: {0}", quantityOfBurritos);
            // How many burritos?: 1

            // ref
            int numberOfBurritos = 1;
            FeedMe(ref numberOfBurritos);
            Console.WriteLine("How many burritos?: {0}", numberOfBurritos);
            // How many burritos?: 2
        }

        // out
        public static void GiveMeFood(out int quantityOfBurritos)
        {
            quantityOfBurritos = 0;
            quantityOfBurritos += 1;
        }

        // ref
        public static void FeedMe(ref int quantityOfBurritos)
        {
            quantityOfBurritos += 1;
        }

    }
}
