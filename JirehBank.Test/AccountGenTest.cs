using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JirehBank.Test
{
    public class AccountGenTest
    {
        [Fact]
        public void RandomNumGenerator_ShouldStartWith()
        {
            // Arrange
            var expected = "0134549894";
            // Act
            var actual = AccountGen.RandomNum(8);
            // Assert
            Assert.Equal(expected.Length, actual.Length);
        }

        [Fact]
        public void RandomNumGenerator_ShouldStartWith01()
        {
            // Arrange
            var expected = "0134549894";
            // Act
            var actual = AccountGen.RandomNum(8);
            // Assert
            Assert.StartsWith("01", actual);
        }
    }
}
