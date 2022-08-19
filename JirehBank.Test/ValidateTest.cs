using Helpers;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JirehBank.Test
{
    public class ValidateTest
    {
        public Mock<IValidate> mock = new Mock<IValidate>();

        [Theory]
        [InlineData("james@test.com", true)]

        public void EmailShouldWork(string email, bool expected)
        {
            //Arrange
            mock.Setup(x => x.EmailChecker(email)).Returns(expected);
            var validate = new Validate();

            //Act
            var actual = validate.EmailChecker(email);

            //Assert
            Assert.True(actual);
        }

        [Theory]
        [InlineData("James", true)]
        public void NameShould(string name, bool expected)
        {
            //Arrange
            mock.Setup(x => x.NameChecker(name)).Returns(expected);
            var validate = new Validate();

            //Act
            var actual = validate.NameChecker(name);

            //Assert
            Assert.True(actual);
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("Great123$", true)]
        public void PasswordShouldReturnTrue(string password, bool expected)
        {
            //Arrange
            mock.Setup(x => x.PasswordChecker(password)).Returns(expected);
            var validate = new Validate();

            //Act
            var actual = validate.PasswordChecker(password);

            //Assert
            Assert.True(actual);
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("08100428870", true)]
        public void PhoneNumberShouldReturnTrue(string phone, bool expected)
        {
            //Arrange
            mock.Setup(x => x.PhoneChecker(phone)).Returns(expected);
            var validate = new Validate();

            //Act
            var actual = validate.PhoneChecker(phone);

            //Assert
            Assert.True(actual);
            Assert.NotNull(actual);
        }
    }
}
