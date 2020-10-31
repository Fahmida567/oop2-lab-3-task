using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.account("Fahmida", "14342567279", 2000);
            a1.output();
            a1.Deposit(1000);
            a1.Withdraw(500);
        }
    }
}
