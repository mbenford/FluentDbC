using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentDbC.Assertions;
using Moq;

namespace FluentDbC.Test
{
    [TestFixture]
    public class AssertionValidatorTest
    {
        [Test]
        public void Throws_An_Exception_When_Validating_Invalid_Assertions()
        {
            // Arrange
            Assertion validAssertion = CreateValidAssertion();
            Assertion invalidAssertion = CreateInvalidAssertion();

            var group = new AssertionGroup();
            group.Add(validAssertion);
            group.Add(invalidAssertion);

            var validator = new AssertionValidator(group);

            // Act/Assert
            Assert.Throws<AssertionInvalidException>(() => validator.Validate());
        }

        [Test]
        public void Does_Not_Throw_Any_Exception_When_Validating_Invalid_Assertions()
        {
            // Arrange
            Assertion firstValidAssertion = CreateValidAssertion();
            Assertion secondValidAssertion = CreateValidAssertion();

            var group = new AssertionGroup();
            group.Add(firstValidAssertion);
            group.Add(secondValidAssertion);

            var validator = new AssertionValidator(group);

            // Act/Assert
            Assert.DoesNotThrow(() => validator.Validate());
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
