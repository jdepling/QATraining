using System;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking QAChecking = new Checking("QA Checking account");
            QAChecking.Deposit(1000);
            QAChecking.Withdraw(100);
            
            Checking Adrianne = new Checking("Adrianne");
            Adrianne.Deposit(5000);
            Adrianne.Transfer(500, Adrianne, QAChecking);

            // After all this code, what do we expect the balances to be?
            // QAChecking should be $1,000 - $100 + $500 = $1,400
            // Adrianne should be $5,000 - $500 = $4,500

            Console.WriteLine($"Adrianne: ${Adrianne.Balance}");
            Console.WriteLine($"QA: ${QAChecking.Balance}");

            // Let's do this with a unit test!
        }
    }
}
