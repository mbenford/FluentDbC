using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FluentDbC.Test.AssertionsTest
{
    [TestFixture]
    public class IsPositiveAssertionTest
    {
        [Test]
        public void Returns_True_When_Validating_Positive_Values()
        {
            // Arrange
            var assertion = new FluentDbC.Assertions.IsPositiveAssertion(1);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Returns_False_When_Validating_Negative_Values()
        {
            // Arrange
            var assertion = new FluentDbC.Assertions.IsPositiveAssertion(-1);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsFalse(result);
        }
    }

}
