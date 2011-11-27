using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace FluentDbC.Test.AssertionsTest
{
    [TestFixture]
    public class IsNullAssertionTest
    {
        [Test]
        public void Returns_True_When_Validating_Null_Values()
        {
            // Arrange
            var assertion = new FluentDbC.Assertions.IsNullAssertion(null);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Returns_False_When_Validating_Non_Null_Values()
        {
            // Arrange
            var assertion = new FluentDbC.Assertions.IsNullAssertion(new object());

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
