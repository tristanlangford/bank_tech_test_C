using System;

namespace Bank_Tech_Test_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            Console.WriteLine("\nInstructions:\nType \"deposit\", \"withdraw\" or \"print statement\"\nType \"exit\" to exit programme\n");
            var response = Console.ReadLine();
            string amount;
            while(response != "exit")
            {
                switch (response)
                {
                    case "deposit":
                        Console.WriteLine("How much would you like to deposit?");
                        amount = Console.ReadLine();
                        account.Deposit(Convert.ToDouble(amount));
                        Console.WriteLine($"£{amount} was deposited");
                        break;
                    case "withdraw":
                        Console.WriteLine("How much would you like to withdraw?");
                        amount = Console.ReadLine();
                        account.Withdraw(Convert.ToDouble(amount));
                        Console.WriteLine($"£{amount} was withdrawn");
                        break;
                    case "print statement":
                        Console.WriteLine(account.Statement());
                        break;
                }
                response = Console.ReadLine();
            }
            
        }
    }
}
