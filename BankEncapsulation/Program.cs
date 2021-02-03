using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var craigsAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());
            craigsAccount.Deposit(amountToDeposit);

      

            Console.WriteLine("How much would you like to withdraw?");

            var amountToWithdraw = double.Parse(Console.ReadLine());
            craigsAccount.Withdraw(amountToWithdraw);

            Console.WriteLine($" Thank You Your balance is now {craigsAccount.GetBalance()}");



        }
    }
}
