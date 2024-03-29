﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentDbC.Assertions;

namespace FluentDbC.Test.AssertionsTest
{
    [TestFixture]
    public class IsNullAssertionTest
    {
        [Test]
        public void Returns_True_When_Validating_Null_Values()
        {
            // Arrange
            var assertion = new IsNullAssertion(null);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Returns_False_When_Validating_Non_Null_Values()
        {
            // Arrange
            var assertion = new IsNullAssertion(new object());

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
