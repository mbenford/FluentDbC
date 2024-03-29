﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentDbC.Assertions;

namespace FluentDbC.Test
{
    [TestFixture]
    public class IsFalseAssertionTest
    {
        [Test]
        public void Returns_True_When_Validating_True_Values()
        {
            // Arrange
            var assertion = new IsFalseAssertion(false);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Returns_False_When_Validating_False_Values()
        {
            // Arrange
            var assertion = new IsFalseAssertion(true);

            // Act
            bool result = assertion.IsValid();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
