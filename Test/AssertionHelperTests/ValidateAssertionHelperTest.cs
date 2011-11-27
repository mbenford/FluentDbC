using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentDbC.Assertions;
using Moq;

namespace FluentDbC.Test.AssertionHelperTests
{
    [TestFixture]
    public class ValidateAssertionHelperTest
    {
        [Test]
        public void Throws_An_Exception_When_Validating_An_Invalid_Assertion()
        {
            // Arrange
            var group = new AssertionGroup();
            Assertion invalidAssertion = CreateInvalidAssertion();

            group.Add(invalidAssertion);

            // Act/Assert
            Assert.Throws<AssertionInvalidException>(() => group.Validate());
        }

        [Test]
        public void Does_Not_Throw_An_Exception_When_Validating_An_Valid_Assertion()
        {
            // Arrange
            var group = new AssertionGroup();
            Assertion validAssertion = CreateValidAssertion();

            group.Add(validAssertion);

            // Act/Assert
            Assert.DoesNotThrow(() => group.Validate());
        }
        private Assertion CreateValidAssertion()
        {
            var assertion = new Mock<Assertion>(null);
            assertion
            .Setup(a => a.IsValid())
            .Returns(true);

            return assertion.Object;
        }

        private Assertion CreateInvalidAssertion()
        {
            var assertion = new Mock<Assertion>(null);
            assertion
            .Setup(a => a.IsValid())
            .Returns(false);

            return assertion.Object;
        }
    }
}
