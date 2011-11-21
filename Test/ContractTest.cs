using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FluentDbC.Test
{
    [TestFixture]
    public class ContractTest
    {
        [Test]
        public void Creates_A_New_Assertion_Group()
        {
            // Arrange
            AssertionGroup group;

            // Act
            group = Contract.Begin();

            // Assert
            Assert.IsNotNull(group);
        }
    }
}
