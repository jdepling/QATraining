namespace QABank
{
    public interface IAccount
    {
        double Balance { get; set; }
        string Name { get; }
        void Withdraw(double amount);
        void Deposit(double amount);
        void Transfer(double amount, IAccount source, IAccount destination);
    }
}
