using System;
using System.Collections.Generic;

namespace ConsoleApp1.Projects
{
    public class BankAccountApp
    {
        void BankAccount_Main()
        {
            Console.WriteLine("Welcome to the Simple Banking System!");
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CreateAccount(accounts);
                        break;
                    case "2":
                        Deposit(accounts);
                        break;
                    case "3":
                        Withdraw(accounts);
                        break;
                    case "4":
                        CheckBalance(accounts);
                        break;
                    case "5":
                        keepRunning = false;
                        Console.WriteLine("Thank you for using the Simple Banking System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        class BankAccount
        {
            public int AccountNumber { get; private set; }
            public string Name { get; private set; }
            public double Balance { get; private set; }

            public BankAccount(int accountNumber, string name, double initialDeposit)
            {
                AccountNumber = accountNumber;
                Name = name;
                Balance = initialDeposit;
            }

            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public bool Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    return true;
                }
                return false;
            }
        }

        static void CreateAccount(Dictionary<int, BankAccount> accounts)
        {
            Console.WriteLine("\nEnter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter an initial deposit amount:");
            double initialDeposit = GetValidAmount();

            int accountNumber = accounts.Count + 1;
            accounts[accountNumber] = new BankAccount(accountNumber, name, initialDeposit);

            Console.WriteLine($"Account created successfully! Your account number is {accountNumber}.");
        }

        static void Deposit(Dictionary<int, BankAccount> accounts)
        {
            Console.WriteLine("\nEnter your account number:");
            int accountNumber = GetValidAccountNumber(accounts);

            Console.WriteLine("Enter the amount to deposit:");
            double amount = GetValidAmount();

            accounts[accountNumber].Deposit(amount);
            Console.WriteLine($"Deposit successful! New balance: {accounts[accountNumber].Balance}");
        }

        static void Withdraw(Dictionary<int, BankAccount> accounts)
        {
            Console.WriteLine("\nEnter your account number:");
            int accountNumber = GetValidAccountNumber(accounts);

            Console.WriteLine("Enter the amount to withdraw:");
            double amount = GetValidAmount();

            if (accounts[accountNumber].Withdraw(amount))
            {
                Console.WriteLine($"Withdrawal successful! New balance: {accounts[accountNumber].Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
        }

        static void CheckBalance(Dictionary<int, BankAccount> accounts)
        {
            Console.WriteLine("\nEnter your account number:");
            int accountNumber = GetValidAccountNumber(accounts);

            Console.WriteLine($"Account Holder: {accounts[accountNumber].Name}");
            Console.WriteLine($"Account Balance: {accounts[accountNumber].Balance}");
        }

        static double GetValidAmount()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    return amount;
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a positive number:");
                }
            }
        }

        static int GetValidAccountNumber(Dictionary<int, BankAccount> accounts)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int accountNumber) && accounts.ContainsKey(accountNumber))
                {
                    return accountNumber;
                }
                else
                {
                    Console.WriteLine("Invalid account number. Please try again:");
                }
            }
        }
    }
}
