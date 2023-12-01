namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string accountNumber = input[0];
            string accountOwner = input[1];
            decimal accountAmount = decimal.Parse(input[2]);

            Account account = new Account(accountNumber, accountOwner,accountAmount);
            account.Deposit(20);
            account.Withdrawal(10);

            account.DisplayAccountDetails();
        }
    }
}