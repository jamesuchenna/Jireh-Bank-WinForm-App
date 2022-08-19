using Core.Interface;
using Core.Services;
using DataAccess.DataStore;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JirehBank.Test
{
    public class CustomerServiceTest
    {
        private readonly IAuthentification _authentification;
        private readonly ICustomerServices _customerServices;
        public CustomerServiceTest()
        {
            _authentification = new Authentification();
            _customerServices = new CustomerServices(_authentification);
        }

        [Fact]
        public void RegisterShouldWork()
        {
            // Arrange
            Customer.IdCount = 0;
            int initIdCount = Customer.IdCount;
            int baseCustomerDataCount = Data.Customer.Count;

            // Act
            _customerServices.RegisterUser("James", "Uchenna", "james@test.com", "Great123$", "08100427880");

            // Assert
            Assert.NotEqual(initIdCount, Data.Customer.Count);
            Assert.NotEqual(initIdCount, Customer.IdCount);
            Assert.True(initIdCount < Customer.IdCount);
            Assert.True(initIdCount < Data.Customer.Count);
        }
    }
}
