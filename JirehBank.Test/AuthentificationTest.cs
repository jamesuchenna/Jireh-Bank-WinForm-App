using Core.Interface;
using Core.Services;
using DataAccess.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JirehBank.Test
{
    public class AuthentificationTest
    {
        private readonly IAuthentification authentification;
        private readonly ICustomerServices customerServices;
        public AuthentificationTest()
        {
            Data.currentUser = null;
            authentification = new Authentification();
            customerServices = new CustomerServices(authentification);
            customerServices.RegisterUser("James", "Uchenna", "james@test.com", "Great123$", "08100427880");
        }

        [Fact]

        public void LoginShouldReturnTrue()
        {
            bool status = authentification.CustomerLogin("james@test.com", "Great123$");
            Assert.True(status);
            Assert.NotNull(Data.currentUser);
        }

        [Fact]
        public void LogOutShouldBeValid()
        {
            authentification.CustomerLogOut();

            Assert.Null(Data.currentUser);
        }
    }
}
