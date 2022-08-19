using Core.Services;
using DataAccess.DataStore;
using Domain.Models;
using Xunit;

namespace JirehBank.Test
{
    public class AccountServicesTest
    {
        private readonly AccountServices _accountServices;
        private readonly Transaction _transaction;
        private readonly Account _account;
        private readonly Customer _customer;
        public AccountServicesTest()
        {
            _accountServices = new AccountServices();
            _account = Data.Accounts.Last();
            _transaction = new Transaction();
            _customer = new Customer();
        }

        [Fact]
        public void CreateAccountShouldBrValid()
        {
            // Arrange
            Account.IdCount = 0;
            var initialIdCount = Account.IdCount;
            var initialAccCount = Data.Accounts.Count;

            // Act
            _accountServices.CreateAccount(1000, 2, _customer);

            // Assert
            Assert.True(initialIdCount > Account.IdCount);
            Assert.Equal(initialAccCount, Data.Accounts.Count);
        }

        [Fact]
        public void DepositTestShouldReturnTrue()
        {
            // Arrange
            double initialBal = _account.Balance;

            // Act
            _accountServices.Deposit(4500, _account);

            // Assert
            Assert.NotEqual(initialBal, _account.Balance);
            Assert.True(_account.Balance > initialBal);
        }

        [Fact]
        public void CheckBalanceShouldBeValid()
        {
            // Arrange
            double expectedBalance = _account.Balance;

            // Act
            var account = new Account();
            var actualBalance = account.Balance;

            // Assert
            Assert.Equal(expectedBalance, actualBalance);
        }
    }
}
