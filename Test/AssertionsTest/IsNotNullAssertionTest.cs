using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentDbC.Assertions;

namespace FluentDbC.Test.AssertionsTest
{
    [TestFixture]
    public class IsNotNullAssertionTest
    {
        [Test]
        public void Returns_True_When_Validating_Non_Null_Values()
        {
            // Arrange
            var assertion = new IsNotNullAssertion(new object());

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Returns_False_When_Validating_Null_Values()
        {
            // Arrange
            var assertion = new IsNotNullAssertion(null);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsFalse(result);
        }
    }

}
