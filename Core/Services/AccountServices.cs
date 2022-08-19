using Core.Interface;
using DataAccess.DataStore;
using Domain.Enums;
using Domain.Models;
using Helpers;

namespace Core.Services
{
    public class AccountServices : IAccountServices
    {
        /// <summary>
        /// Method for account creation
        /// </summary>
        public void CreateAccount(double firstDep, int accountType, Customer customer)
        {
            var account = new Account()
            {
                AccountName = customer.FullName,
                AccountNumber = AccountGen.RandomNum(8),
                Type = accountType == 1 ? AccountType.Savings : AccountType.Current,
                Balance = firstDep,
                CustomerId = customer.Id,
                IsActive = true
            };
            Data.Accounts.Add(account);
            //customer.Accounts.Add(account);

            Transaction.TransactionIdCount++;
            Transaction transaction = new Transaction()
            {
                TransactionId = Transaction.TransactionIdCount,
                Amount = firstDep,
                AccountId = account.Id,
                Balance = account.Balance,
                AccountType = account.Type,
                Description = $"Initial deposit",
                Date = DateTime.Now,
                Category = "Credit"
            };
            Data.Transactions.Add(transaction);
        }

        /// <summary>
        /// Method for account balance check
        /// </summary>
        public double CheckBalance(Account account)
        {
            return account.Balance;
        }

        /// <summary>
        /// Method for account deposit
        /// </summary>
        public void Deposit(double amount, Account account)
        {
            if (amount > 0)
            {
                account.Balance += amount;

                Transaction.TransactionIdCount++;
                Transaction transaction = new Transaction()
                {
                    TransactionId = Transaction.TransactionIdCount,
                    Amount = amount,
                    AccountId = account.Id,
                    Balance = account.Balance,
                    AccountType = account.Type,
                    Description = $"Money deposited",
                    Date = DateTime.Now,
                    Category = "Credit"
                };
                Data.Transactions.Add(transaction);
            }
        }

        /// <summary>
        /// Method for account withdrawal
        /// </summary>
        public bool Withdrawal(double amount, Account account)
        {
            if (account.Type == AccountType.Savings)
            {
                if (account.Balance - amount >= 1000)
                {
                    account.Balance -= amount;

                    Transaction.TransactionIdCount++;
                    Transaction transaction = new Transaction()
                    {
                        TransactionId = Transaction.TransactionIdCount,
                        Amount = amount,
                        AccountId = account.Id,
                        Balance = account.Balance,
                        AccountType = account.Type,
                        Description = $"Money withdrawn",
                        Date = DateTime.Now,
                        Category = "Debit"
                    };
                    Data.Transactions.Add(transaction);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (account.Type == AccountType.Current)
            {
                if (account.Balance - amount >= 0)
                {
                    account.Balance -= amount;
                    Transaction.TransactionIdCount++;

                    Transaction transaction = new Transaction()
                    {
                        TransactionId = Transaction.TransactionIdCount,
                        Amount = amount,
                        AccountId = account.Id,
                        Balance = account.Balance,
                        AccountType = account.Type,
                        Description = $"Money withdrawn",
                        Date = DateTime.Now,
                        Category = "Credit"
                    };
                    Data.Transactions.Add(transaction);
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insufficient balance! Try again");
                    Console.ResetColor();
                    Console.ReadLine();
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Method for account Transfer
        /// </summary>
        public void Transfer(double amount, Account sender, Account dest)
        {
            sender.Balance -= amount;
            Transaction.TransactionIdCount++;

            Transaction transaction = new Transaction()
            {
                TransactionId = Transaction.TransactionIdCount,
                Amount = amount,
                AccountId = sender.Id,
                Balance = sender.Balance,
                AccountType = sender.Type,
                Description = $"Money sent to {dest.AccountNumber}",
                Date = DateTime.Now,
                Category = "Debit"
            };
            Data.Transactions.Add(transaction);

            dest.Balance += amount;

            Transaction transaction1 = new Transaction()
            {
                TransactionId = Transaction.TransactionIdCount,
                AccountId = dest.Id,
                Balance = dest.Balance,
                AccountType = dest.Type,
                Amount = amount,
                Description = $"Received from {sender.AccountNumber}",
                Category = "Credit",
                Date = DateTime.Now
            };
            Data.Transactions.Add(transaction1);
        }
    }
}