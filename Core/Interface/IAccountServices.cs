using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IAccountServices
    {
        void CreateAccount(double firstDep, int accountType, Customer customer);
        double CheckBalance(Account account);
        void Deposit(double amount, Account account);
        bool Withdrawal(double amount, Account account);
        void Transfer(double amount, Account sender, Account dest);
    }
}
