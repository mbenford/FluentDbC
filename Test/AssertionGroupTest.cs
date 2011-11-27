using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentDbC;
using Moq;
using FluentDbC.Assertions;

namespace FluentDbC.Test
{
    [TestFixture]
    public class AssertionGroupTest
    {
        [Test]
        public void Adds_Assertion_To_The_End_Of_The_Group()
        {
            // Arrange
            var group = new AssertionGroup();
            Assertion assertion = CreateFakeAssertion();

            // Act            
            group.Add(CreateFakeAssertion());
            group.Add(CreateFakeAssertion());
            group.Add(assertion);

            // Assert
            Assert.AreEqual(assertion, group.Last());
        }

        [Test]
        public void Iterates_Through_Assertions_From_Oldest_To_Newest()
        {
            // Arrange
            var group = new AssertionGroup();
            Assertion assertion1 = CreateFakeAssertion();
            Assertion assertion2 = CreateFakeAssertion();
            Assertion assertion3 = CreateFakeAssertion();

            group.Add(assertion1);
            group.Add(assertion2);
            group.Add(assertion3);

            var assertions = new List<Assertion>();

            // Act
            foreach (Assertion assertion in group)
            {
                assertions.Add(assertion);
            }

            // Assert
            Assert.AreEqual(assertion1, assertions[0]);
            Assert.AreEqual(assertion2, assertions[1]);
            Assert.AreEqual(assertion3, assertions[2]);
        }

        private Assertion CreateFakeAssertion()
        {
            return new Mock<Assertion>(null).Object;
        }
    }
}
