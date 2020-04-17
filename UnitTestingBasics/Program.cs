using System;

namespace UnitTestingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            QaClassToTest ourClass = new QaClassToTest();
            
            // Use our example method
            var exampleMethodOutput = ourClass.MethodToTest(2, Item.Shotgun);
            Console.WriteLine("ExampleMethodOutput: {0:C}", exampleMethodOutput);

            // Use Adrianne's method
            ourClass.AdrianneMethodToTest();

            // Use Chris's method
            ourClass.ChrisMethodToTest();

            // Use Matt's method
            ourClass.MattMethodToTest();

            // Use Nick's method
            ourClass.NickMethodToTest();
        }
    }
}
